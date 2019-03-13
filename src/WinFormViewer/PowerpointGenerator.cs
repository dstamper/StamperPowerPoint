using ImageRequest;
using R = RtfPipe;
using SharedModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using PowerPointExport;
using System.Drawing.Imaging;
using System.Runtime.Serialization;
using System.Net;
using System.IO;

namespace WinFormViewer
{
    public partial class PowerpointGenerator : Form
    {
        private readonly IImageClient _imageClient;
        private IList<ImageModel> pictureBoxes;
        private IList<ImageModel> selectedImages;

        public PowerpointGenerator(IImageClient imageClient)
        {
            InitializeComponent();
            _imageClient = imageClient;
            pictureBoxes = new List<ImageModel>
            {
                new ImageModel { Box = pictureBox1 },
                new ImageModel { Box = pictureBox2 },
                new ImageModel { Box = pictureBox3 },
                new ImageModel { Box = pictureBox4 },
                new ImageModel { Box = pictureBox5 },
                new ImageModel { Box = pictureBox6 },
                new ImageModel { Box = pictureBox7 },
                new ImageModel { Box = pictureBox8 },
                new ImageModel { Box = pictureBox9 },
                new ImageModel { Box = pictureBox10 }

            };

            foreach ( var picture in pictureBoxes)
            {
                picture.Box.Click += new EventHandler(imageSelect_Click);
            }

            selectedImages = new List<ImageModel>
            {
                new ImageModel { Box = selectedImage1 },
                new ImageModel { Box = selectedImage2 },
                new ImageModel { Box = selectedImage3 }
            };

            foreach (var image in selectedImages)
            {
                image.Box.Click += new EventHandler(imageRemove_Click);
            }
        }

        public PowerpointGenerator() : this(ImageClientFactory.Create())
        {

        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            BoldText();
        }

        private void bodyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                BoldText();
            }
        }

        private void BoldText()
        {
            Font currentFont = bodyTextBox.SelectionFont;
            FontStyle newFontStyle;
            if (bodyTextBox.SelectionFont.Bold == true)
            {
                newFontStyle = FontStyle.Regular;
            }
            else
            {
                newFontStyle = FontStyle.Bold;
            }

            bodyTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
        }

        private async void lookupButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> searchTerms = new List<string>();
                var titleString = titleTextBox.Text.Trim();
                if(titleString != String.Empty)
                {
                    searchTerms.Add(titleString);
                }
                var rtf = bodyTextBox.Rtf;
                var html = R.Rtf.ToHtml(rtf);
                var matches = Regex.Matches(html, @"<strong>([^<]*)<\/strong>");
                foreach ( Match match in matches)
                {
                    var boldText = match.Groups[1].Value.Trim();
                    if(boldText != String.Empty)
                    {
                        searchTerms.Add(boldText);
                    }
                }

                if (searchTerms.Count == 0)
                {
                    return;
                }
                //Due to API budget, we'll take the title and up to first two bold results
                var queryResults = new List<PowerPointImage>();
                foreach (var term in searchTerms.Take(3))
                {
                    var results = await _imageClient.MakeRequest(term);
                    queryResults = queryResults.Concat(results).ToList();
                }
                if(queryResults.Count < 10)
                {
                    //Haven't found 10 yet, attempt to get remaining terms
                    foreach (var term in searchTerms.Skip(3))
                    {
                        var results = await _imageClient.MakeRequest(term);
                        queryResults = queryResults.Concat(results).ToList();
                        if(queryResults.Count < 10)
                        {
                            //Exhausted search terms, no more wasting API calls
                            break;
                        }
                    }

                }
                //Rough shuffle for distribution based on hashed ID
                queryResults = queryResults.OrderBy(x => x.Id).ToList();
                var imageStack = new Stack<PowerPointImage>(queryResults.Take(10));
                foreach ( var localItem in pictureBoxes)
                {
                    if (imageStack.Any())
                    {
                        var image = imageStack.Pop();
                        localItem.Box.LoadAsync(image.Urls.Thumb);
                        var modelBox = pictureBoxes.Single(model => model.Box == localItem.Box);
                        modelBox.PowerPoint = image;

                    }
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void imageSelect_Click(object sender, EventArgs e)
        {
            var picture = sender as PictureBox;            
            if (picture == null || picture.Image == null)
            {
                return;
            }

            //If any not equal to null -> then continue
            if (selectedImages.Count(model => model.PowerPoint == null) == 0)
            {
                return;
            }
            
            var modelBox = pictureBoxes.FirstOrDefault(model => model.Box == picture);
            //Check duplicates
            if(selectedImages.Any(model => model.PowerPoint == modelBox.PowerPoint))
            {
                return;
            }
            //checking for click, before loading or if empty images present
            if(modelBox == null || modelBox.PowerPoint == null)
            {
                return;
            }
            //first empty slot
            var imageToSelect = selectedImages.First(model => model.PowerPoint == null);
            imageToSelect.Box.LoadAsync(modelBox.PowerPoint.Urls.Thumb);
            imageToSelect.PowerPoint = modelBox.PowerPoint;
            
        }

        private void imageRemove_Click(object sender, EventArgs e)
        {
            var picture = sender as PictureBox;
            if (picture == null || picture.Image == null)
            {
                return;
            }

            var pictureToRemove = selectedImages.First(model => model.Box == picture);
            pictureToRemove.PowerPoint = null;
            pictureToRemove.Box.Image = null;

        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            if(!selectedImages.Any(model => model.PowerPoint != null))
            {
                MessageBox.Show("No images selected!");
                return;
            }

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            var selectedPath = folderBrowserDialog.SelectedPath;
            
            using (var webClient = new WebClient())
            {
                foreach (var image in selectedImages.Where(model => model.PowerPoint != null))
                {
                    var path = Path.Combine(selectedPath, image.PowerPoint.Id + ".jpg");
                    webClient.DownloadFile(new Uri(image.PowerPoint.Urls.Full), path);
                }
                MessageBox.Show("Downloading files begun, will be done shortly.");
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter a title, and then bold any words in the body of the powerpoint.\n" +
                "You may select the text and click the bold button, or use Ctrl + B on your keyboard.\n" +
                "Press the lookup button to search for web images with these criteria.\n" +
                "Finally, select up to three images to download as an aid for your powerpoint project.\n" +
                "The API I'm using is rate limited, so I do my best to limit the images to 3 seperate requests. I get 50 an hour.\n" +
                "Quick reminder that my GitHub repo does not include my Access Key!\n" +
                "Please insert it in App.config if you are builiding the source, or use a valid WinFormViewer.exe.config");
        }
    }
}
