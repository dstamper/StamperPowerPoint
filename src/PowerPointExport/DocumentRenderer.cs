using Microsoft.Office.Interop.PowerPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPointExport
{
    public class DocumentRenderer
    {
        public static void ExportToPowerPoint(string baseDirectory, List<string> files, string inputTitle, string inputBody)
        {
            Application app = new Application();
            Presentation p = app.Presentations.Add(Microsoft.Office.Core.MsoTriState.msoTrue);
            var layout = app.ActivePresentation.SlideMaster.CustomLayouts[1];
            var slide = app.ActivePresentation.Slides.AddSlide(1, layout);

            int shapeIndex = 1;
            
            for(int i = 0; i < files.Count; i++)
            {
                var path = baseDirectory + "\\" + files[i];
                var image = slide.Shapes.AddPicture(path, Microsoft.Office.Core.MsoTriState.msoTrue, Microsoft.Office.Core.MsoTriState.msoTrue, 0f + (100*i), 0f + (100*i));
            }

            var title = slide.Shapes[shapeIndex++].TextFrame.TextRange;
            title.Text = inputTitle;
            title.Font.Size = 48;

            var body = slide.Shapes[shapeIndex++].TextFrame.TextRange;
            body.Text = inputBody;

            slide.Shapes[1].ZOrder(Microsoft.Office.Core.MsoZOrderCmd.msoBringToFront);

        }
    }
}
