using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml;
using A = DocumentFormat.OpenXml.Drawing;
using P15 = DocumentFormat.OpenXml.Office2013.PowerPoint;
using P14 = DocumentFormat.OpenXml.Office2010.PowerPoint;
using A14 = DocumentFormat.OpenXml.Office2010.Drawing;
using Thm15 = DocumentFormat.OpenXml.Office2013.Theme;
using Ap = DocumentFormat.OpenXml.ExtendedProperties;
using Vt = DocumentFormat.OpenXml.VariantTypes;
using System.Collections.Generic;

/**
 * Generated almost entirely with an empty powerpoint presentation using the Open XML SDK 2.5 Refelector tool
 * https://www.microsoft.com/en-us/download/details.aspx?id=30425 * 
 * 
 */

namespace PowerPointExport
{
    public class GeneratedClass
    {
        private string _inputTitle = "";
        private string _inputBody = "";
        private string _image1 = "";
        private string _image2 = "";
        private string _image3 = "";

        // Creates a PresentationDocument.
        public void CreatePackage(string filePath, string title, string body, List<string> images)
        {
            _inputTitle = title;
            _inputBody = body;
            
            if(images != null)
            {
                if(images.Count > 0 && images[0] != null)
                {
                    _image1 = images[0];
                }
                if (images.Count > 1 && images[1] != null)
                {
                    _image2 = images[1];
                }
                if (images.Count > 2 && images[2] != null)
                {
                    _image3 = images[2];
                }
            }

            using (PresentationDocument package = PresentationDocument.Create(filePath, PresentationDocumentType.Presentation))
            {
                CreateParts(package);
            }
        }

        // Adds child parts and generates content of the specified part.
        private void CreateParts(PresentationDocument document)
        {
            ThumbnailPart thumbnailPart1 = document.AddNewPart<ThumbnailPart>("image/jpeg", "rId2");
            GenerateThumbnailPart1Content(thumbnailPart1);

            PresentationPart presentationPart1 = document.AddPresentationPart();
            GeneratePresentationPart1Content(presentationPart1);

            PresentationPropertiesPart presentationPropertiesPart1 = presentationPart1.AddNewPart<PresentationPropertiesPart>("rId3");
            GeneratePresentationPropertiesPart1Content(presentationPropertiesPart1);

            SlidePart slidePart1 = presentationPart1.AddNewPart<SlidePart>("rId2");
            GenerateSlidePart1Content(slidePart1);

            ImagePart imagePart1 = slidePart1.AddNewPart<ImagePart>("image/jpeg", "rId3");
            GenerateImagePart1Content(imagePart1);

            ImagePart imagePart2 = slidePart1.AddNewPart<ImagePart>("image/jpeg", "rId2");
            GenerateImagePart2Content(imagePart2);

            SlideLayoutPart slideLayoutPart1 = slidePart1.AddNewPart<SlideLayoutPart>("rId1");
            GenerateSlideLayoutPart1Content(slideLayoutPart1);

            SlideMasterPart slideMasterPart1 = slideLayoutPart1.AddNewPart<SlideMasterPart>("rId1");
            GenerateSlideMasterPart1Content(slideMasterPart1);

            ThemePart themePart1 = slideMasterPart1.AddNewPart<ThemePart>("rId2");
            GenerateThemePart1Content(themePart1);

            slideMasterPart1.AddPart(slideLayoutPart1, "rId1");

            ImagePart imagePart3 = slidePart1.AddNewPart<ImagePart>("image/jpeg", "rId4");
            GenerateImagePart3Content(imagePart3);

            presentationPart1.AddPart(slideMasterPart1, "rId1");

            TableStylesPart tableStylesPart1 = presentationPart1.AddNewPart<TableStylesPart>("rId6");
            GenerateTableStylesPart1Content(tableStylesPart1);

            presentationPart1.AddPart(themePart1, "rId5");

            ViewPropertiesPart viewPropertiesPart1 = presentationPart1.AddNewPart<ViewPropertiesPart>("rId4");
            GenerateViewPropertiesPart1Content(viewPropertiesPart1);

            ExtendedFilePropertiesPart extendedFilePropertiesPart1 = document.AddNewPart<ExtendedFilePropertiesPart>("rId4");
            GenerateExtendedFilePropertiesPart1Content(extendedFilePropertiesPart1);

            SetPackageProperties(document);
        }

        // Generates content of thumbnailPart1.
        private void GenerateThumbnailPart1Content(ThumbnailPart thumbnailPart1)
        {
            System.IO.Stream data = GetBinaryDataStream(thumbnailPart1Data);
            thumbnailPart1.FeedData(data);
            data.Close();
        }

        // Generates content of presentationPart1.
        private void GeneratePresentationPart1Content(PresentationPart presentationPart1)
        {
            Presentation presentation1 = new Presentation() { SaveSubsetFonts = true };
            presentation1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            presentation1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            presentation1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            SlideMasterIdList slideMasterIdList1 = new SlideMasterIdList();
            SlideMasterId slideMasterId1 = new SlideMasterId() { Id = (UInt32Value)2147483648U, RelationshipId = "rId1" };

            slideMasterIdList1.Append(slideMasterId1);

            SlideIdList slideIdList1 = new SlideIdList();
            SlideId slideId1 = new SlideId() { Id = (UInt32Value)256U, RelationshipId = "rId2" };

            slideIdList1.Append(slideId1);
            SlideSize slideSize1 = new SlideSize() { Cx = 12192000, Cy = 6858000 };
            NotesSize notesSize1 = new NotesSize() { Cx = 6858000L, Cy = 9144000L };

            DefaultTextStyle defaultTextStyle1 = new DefaultTextStyle();

            A.DefaultParagraphProperties defaultParagraphProperties1 = new A.DefaultParagraphProperties();
            A.DefaultRunProperties defaultRunProperties1 = new A.DefaultRunProperties() { Language = "en-US" };

            defaultParagraphProperties1.Append(defaultRunProperties1);

            A.Level1ParagraphProperties level1ParagraphProperties1 = new A.Level1ParagraphProperties() { LeftMargin = 0, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties2 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill1 = new A.SolidFill();
            A.SchemeColor schemeColor1 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill1.Append(schemeColor1);
            A.LatinFont latinFont1 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont1 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont1 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties2.Append(solidFill1);
            defaultRunProperties2.Append(latinFont1);
            defaultRunProperties2.Append(eastAsianFont1);
            defaultRunProperties2.Append(complexScriptFont1);

            level1ParagraphProperties1.Append(defaultRunProperties2);

            A.Level2ParagraphProperties level2ParagraphProperties1 = new A.Level2ParagraphProperties() { LeftMargin = 457200, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties3 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill2 = new A.SolidFill();
            A.SchemeColor schemeColor2 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill2.Append(schemeColor2);
            A.LatinFont latinFont2 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont2 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont2 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties3.Append(solidFill2);
            defaultRunProperties3.Append(latinFont2);
            defaultRunProperties3.Append(eastAsianFont2);
            defaultRunProperties3.Append(complexScriptFont2);

            level2ParagraphProperties1.Append(defaultRunProperties3);

            A.Level3ParagraphProperties level3ParagraphProperties1 = new A.Level3ParagraphProperties() { LeftMargin = 914400, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties4 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill3 = new A.SolidFill();
            A.SchemeColor schemeColor3 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill3.Append(schemeColor3);
            A.LatinFont latinFont3 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont3 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont3 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties4.Append(solidFill3);
            defaultRunProperties4.Append(latinFont3);
            defaultRunProperties4.Append(eastAsianFont3);
            defaultRunProperties4.Append(complexScriptFont3);

            level3ParagraphProperties1.Append(defaultRunProperties4);

            A.Level4ParagraphProperties level4ParagraphProperties1 = new A.Level4ParagraphProperties() { LeftMargin = 1371600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties5 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill4 = new A.SolidFill();
            A.SchemeColor schemeColor4 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill4.Append(schemeColor4);
            A.LatinFont latinFont4 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont4 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont4 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties5.Append(solidFill4);
            defaultRunProperties5.Append(latinFont4);
            defaultRunProperties5.Append(eastAsianFont4);
            defaultRunProperties5.Append(complexScriptFont4);

            level4ParagraphProperties1.Append(defaultRunProperties5);

            A.Level5ParagraphProperties level5ParagraphProperties1 = new A.Level5ParagraphProperties() { LeftMargin = 1828800, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties6 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill5 = new A.SolidFill();
            A.SchemeColor schemeColor5 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill5.Append(schemeColor5);
            A.LatinFont latinFont5 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont5 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont5 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties6.Append(solidFill5);
            defaultRunProperties6.Append(latinFont5);
            defaultRunProperties6.Append(eastAsianFont5);
            defaultRunProperties6.Append(complexScriptFont5);

            level5ParagraphProperties1.Append(defaultRunProperties6);

            A.Level6ParagraphProperties level6ParagraphProperties1 = new A.Level6ParagraphProperties() { LeftMargin = 2286000, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties7 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill6 = new A.SolidFill();
            A.SchemeColor schemeColor6 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill6.Append(schemeColor6);
            A.LatinFont latinFont6 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont6 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont6 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties7.Append(solidFill6);
            defaultRunProperties7.Append(latinFont6);
            defaultRunProperties7.Append(eastAsianFont6);
            defaultRunProperties7.Append(complexScriptFont6);

            level6ParagraphProperties1.Append(defaultRunProperties7);

            A.Level7ParagraphProperties level7ParagraphProperties1 = new A.Level7ParagraphProperties() { LeftMargin = 2743200, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties8 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill7 = new A.SolidFill();
            A.SchemeColor schemeColor7 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill7.Append(schemeColor7);
            A.LatinFont latinFont7 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont7 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont7 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties8.Append(solidFill7);
            defaultRunProperties8.Append(latinFont7);
            defaultRunProperties8.Append(eastAsianFont7);
            defaultRunProperties8.Append(complexScriptFont7);

            level7ParagraphProperties1.Append(defaultRunProperties8);

            A.Level8ParagraphProperties level8ParagraphProperties1 = new A.Level8ParagraphProperties() { LeftMargin = 3200400, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties9 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill8 = new A.SolidFill();
            A.SchemeColor schemeColor8 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill8.Append(schemeColor8);
            A.LatinFont latinFont8 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont8 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont8 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties9.Append(solidFill8);
            defaultRunProperties9.Append(latinFont8);
            defaultRunProperties9.Append(eastAsianFont8);
            defaultRunProperties9.Append(complexScriptFont8);

            level8ParagraphProperties1.Append(defaultRunProperties9);

            A.Level9ParagraphProperties level9ParagraphProperties1 = new A.Level9ParagraphProperties() { LeftMargin = 3657600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties10 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill9 = new A.SolidFill();
            A.SchemeColor schemeColor9 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill9.Append(schemeColor9);
            A.LatinFont latinFont9 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont9 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont9 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties10.Append(solidFill9);
            defaultRunProperties10.Append(latinFont9);
            defaultRunProperties10.Append(eastAsianFont9);
            defaultRunProperties10.Append(complexScriptFont9);

            level9ParagraphProperties1.Append(defaultRunProperties10);

            defaultTextStyle1.Append(defaultParagraphProperties1);
            defaultTextStyle1.Append(level1ParagraphProperties1);
            defaultTextStyle1.Append(level2ParagraphProperties1);
            defaultTextStyle1.Append(level3ParagraphProperties1);
            defaultTextStyle1.Append(level4ParagraphProperties1);
            defaultTextStyle1.Append(level5ParagraphProperties1);
            defaultTextStyle1.Append(level6ParagraphProperties1);
            defaultTextStyle1.Append(level7ParagraphProperties1);
            defaultTextStyle1.Append(level8ParagraphProperties1);
            defaultTextStyle1.Append(level9ParagraphProperties1);

            PresentationExtensionList presentationExtensionList1 = new PresentationExtensionList();

            PresentationExtension presentationExtension1 = new PresentationExtension() { Uri = "{EFAFB233-063F-42B5-8137-9DF3F51BA10A}" };

            P15.SlideGuideList slideGuideList1 = new P15.SlideGuideList();
            slideGuideList1.AddNamespaceDeclaration("p15", "http://schemas.microsoft.com/office/powerpoint/2012/main");

            presentationExtension1.Append(slideGuideList1);

            presentationExtensionList1.Append(presentationExtension1);

            presentation1.Append(slideMasterIdList1);
            presentation1.Append(slideIdList1);
            presentation1.Append(slideSize1);
            presentation1.Append(notesSize1);
            presentation1.Append(defaultTextStyle1);
            presentation1.Append(presentationExtensionList1);

            presentationPart1.Presentation = presentation1;
        }

        // Generates content of presentationPropertiesPart1.
        private void GeneratePresentationPropertiesPart1Content(PresentationPropertiesPart presentationPropertiesPart1)
        {
            PresentationProperties presentationProperties1 = new PresentationProperties();
            presentationProperties1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            presentationProperties1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            presentationProperties1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            PresentationPropertiesExtensionList presentationPropertiesExtensionList1 = new PresentationPropertiesExtensionList();

            PresentationPropertiesExtension presentationPropertiesExtension1 = new PresentationPropertiesExtension() { Uri = "{E76CE94A-603C-4142-B9EB-6D1370010A27}" };

            P14.DiscardImageEditData discardImageEditData1 = new P14.DiscardImageEditData() { Val = false };
            discardImageEditData1.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            presentationPropertiesExtension1.Append(discardImageEditData1);

            PresentationPropertiesExtension presentationPropertiesExtension2 = new PresentationPropertiesExtension() { Uri = "{D31A062A-798A-4329-ABDD-BBA856620510}" };

            P14.DefaultImageDpi defaultImageDpi1 = new P14.DefaultImageDpi() { Val = (UInt32Value)32767U };
            defaultImageDpi1.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            presentationPropertiesExtension2.Append(defaultImageDpi1);

            PresentationPropertiesExtension presentationPropertiesExtension3 = new PresentationPropertiesExtension() { Uri = "{FD5EFAAD-0ECE-453E-9831-46B23BE46B34}" };

            P15.ChartTrackingReferenceBased chartTrackingReferenceBased1 = new P15.ChartTrackingReferenceBased() { Val = true };
            chartTrackingReferenceBased1.AddNamespaceDeclaration("p15", "http://schemas.microsoft.com/office/powerpoint/2012/main");

            presentationPropertiesExtension3.Append(chartTrackingReferenceBased1);

            presentationPropertiesExtensionList1.Append(presentationPropertiesExtension1);
            presentationPropertiesExtensionList1.Append(presentationPropertiesExtension2);
            presentationPropertiesExtensionList1.Append(presentationPropertiesExtension3);

            presentationProperties1.Append(presentationPropertiesExtensionList1);

            presentationPropertiesPart1.PresentationProperties = presentationProperties1;
        }

        // Generates content of slidePart1.
        private void GenerateSlidePart1Content(SlidePart slidePart1)
        {
            Slide slide1 = new Slide();
            slide1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slide1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slide1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData1 = new CommonSlideData();

            ShapeTree shapeTree1 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties1 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties1 = new NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties1 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties1 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties1.Append(nonVisualDrawingProperties1);
            nonVisualGroupShapeProperties1.Append(nonVisualGroupShapeDrawingProperties1);
            nonVisualGroupShapeProperties1.Append(applicationNonVisualDrawingProperties1);

            GroupShapeProperties groupShapeProperties1 = new GroupShapeProperties();

            A.TransformGroup transformGroup1 = new A.TransformGroup();
            A.Offset offset1 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents1 = new A.Extents() { Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset1 = new A.ChildOffset() { X = 0L, Y = 0L };
            A.ChildExtents childExtents1 = new A.ChildExtents() { Cx = 0L, Cy = 0L };

            transformGroup1.Append(offset1);
            transformGroup1.Append(extents1);
            transformGroup1.Append(childOffset1);
            transformGroup1.Append(childExtents1);

            groupShapeProperties1.Append(transformGroup1);

            Picture picture1 = new Picture();

            NonVisualPictureProperties nonVisualPictureProperties1 = new NonVisualPictureProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties2 = new NonVisualDrawingProperties() { Id = (UInt32Value)12U, Name = "Picture 11" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList1 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension1 = new A.NonVisualDrawingPropertiesExtension() { Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement1 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{A812611A-21A3-4C7F-BE8D-5FD914E4A0AC}\" />");

            nonVisualDrawingPropertiesExtension1.Append(openXmlUnknownElement1);

            nonVisualDrawingPropertiesExtensionList1.Append(nonVisualDrawingPropertiesExtension1);

            nonVisualDrawingProperties2.Append(nonVisualDrawingPropertiesExtensionList1);

            NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties1 = new NonVisualPictureDrawingProperties();
            A.PictureLocks pictureLocks1 = new A.PictureLocks() { NoChangeAspect = true };

            nonVisualPictureDrawingProperties1.Append(pictureLocks1);
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties2 = new ApplicationNonVisualDrawingProperties();

            nonVisualPictureProperties1.Append(nonVisualDrawingProperties2);
            nonVisualPictureProperties1.Append(nonVisualPictureDrawingProperties1);
            nonVisualPictureProperties1.Append(applicationNonVisualDrawingProperties2);

            BlipFill blipFill1 = new BlipFill();

            A.Blip blip1 = new A.Blip() { Embed = "rId2" };

            A.BlipExtensionList blipExtensionList1 = new A.BlipExtensionList();

            A.BlipExtension blipExtension1 = new A.BlipExtension() { Uri = "{28A0092B-C50C-407E-A947-70E740481C1C}" };

            A14.UseLocalDpi useLocalDpi1 = new A14.UseLocalDpi() { Val = false };
            useLocalDpi1.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            blipExtension1.Append(useLocalDpi1);

            blipExtensionList1.Append(blipExtension1);

            blip1.Append(blipExtensionList1);

            A.Stretch stretch1 = new A.Stretch();
            A.FillRectangle fillRectangle1 = new A.FillRectangle();

            stretch1.Append(fillRectangle1);

            blipFill1.Append(blip1);
            blipFill1.Append(stretch1);

            ShapeProperties shapeProperties1 = new ShapeProperties();

            A.Transform2D transform2D1 = new A.Transform2D();
            A.Offset offset2 = new A.Offset() { X = -5712700L, Y = 2411278L };
            A.Extents extents2 = new A.Extents() { Cx = 10287000L, Cy = 6858000L };

            transform2D1.Append(offset2);
            transform2D1.Append(extents2);

            A.PresetGeometry presetGeometry1 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList1 = new A.AdjustValueList();

            presetGeometry1.Append(adjustValueList1);

            shapeProperties1.Append(transform2D1);
            shapeProperties1.Append(presetGeometry1);

            picture1.Append(nonVisualPictureProperties1);
            picture1.Append(blipFill1);
            picture1.Append(shapeProperties1);

            Picture picture2 = new Picture();

            NonVisualPictureProperties nonVisualPictureProperties2 = new NonVisualPictureProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties3 = new NonVisualDrawingProperties() { Id = (UInt32Value)5U, Name = "Picture 4", Description = "A close up of a flower\n\nDescription automatically generated" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList2 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension2 = new A.NonVisualDrawingPropertiesExtension() { Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement2 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{F9C42006-1772-4F08-8E11-49C2EA56772C}\" />");

            nonVisualDrawingPropertiesExtension2.Append(openXmlUnknownElement2);

            nonVisualDrawingPropertiesExtensionList2.Append(nonVisualDrawingPropertiesExtension2);

            nonVisualDrawingProperties3.Append(nonVisualDrawingPropertiesExtensionList2);

            NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties2 = new NonVisualPictureDrawingProperties();
            A.PictureLocks pictureLocks2 = new A.PictureLocks() { NoChangeAspect = true };

            nonVisualPictureDrawingProperties2.Append(pictureLocks2);
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties3 = new ApplicationNonVisualDrawingProperties();

            nonVisualPictureProperties2.Append(nonVisualDrawingProperties3);
            nonVisualPictureProperties2.Append(nonVisualPictureDrawingProperties2);
            nonVisualPictureProperties2.Append(applicationNonVisualDrawingProperties3);

            BlipFill blipFill2 = new BlipFill();

            A.Blip blip2 = new A.Blip() { Embed = "rId3" };

            A.BlipExtensionList blipExtensionList2 = new A.BlipExtensionList();

            A.BlipExtension blipExtension2 = new A.BlipExtension() { Uri = "{28A0092B-C50C-407E-A947-70E740481C1C}" };

            A14.UseLocalDpi useLocalDpi2 = new A14.UseLocalDpi() { Val = false };
            useLocalDpi2.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            blipExtension2.Append(useLocalDpi2);

            blipExtensionList2.Append(blipExtension2);

            blip2.Append(blipExtensionList2);

            A.Stretch stretch2 = new A.Stretch();
            A.FillRectangle fillRectangle2 = new A.FillRectangle();

            stretch2.Append(fillRectangle2);

            blipFill2.Append(blip2);
            blipFill2.Append(stretch2);

            ShapeProperties shapeProperties2 = new ShapeProperties();

            A.Transform2D transform2D2 = new A.Transform2D();
            A.Offset offset3 = new A.Offset() { X = 0L, Y = -4338536L };
            A.Extents extents3 = new A.Extents() { Cx = 4574300L, Cy = 6858000L };

            transform2D2.Append(offset3);
            transform2D2.Append(extents3);

            A.PresetGeometry presetGeometry2 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList2 = new A.AdjustValueList();

            presetGeometry2.Append(adjustValueList2);

            shapeProperties2.Append(transform2D2);
            shapeProperties2.Append(presetGeometry2);

            picture2.Append(nonVisualPictureProperties2);
            picture2.Append(blipFill2);
            picture2.Append(shapeProperties2);

            Picture picture3 = new Picture();

            NonVisualPictureProperties nonVisualPictureProperties3 = new NonVisualPictureProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties4 = new NonVisualDrawingProperties() { Id = (UInt32Value)8U, Name = "Picture 7", Description = "A close up of a clock\n\nDescription automatically generated" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList3 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension3 = new A.NonVisualDrawingPropertiesExtension() { Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement3 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{3D912EC9-9D72-40B3-9F1B-DE62ADEA5F11}\" />");

            nonVisualDrawingPropertiesExtension3.Append(openXmlUnknownElement3);

            nonVisualDrawingPropertiesExtensionList3.Append(nonVisualDrawingPropertiesExtension3);

            nonVisualDrawingProperties4.Append(nonVisualDrawingPropertiesExtensionList3);

            NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties3 = new NonVisualPictureDrawingProperties();
            A.PictureLocks pictureLocks3 = new A.PictureLocks() { NoChangeAspect = true };

            nonVisualPictureDrawingProperties3.Append(pictureLocks3);
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties4 = new ApplicationNonVisualDrawingProperties();

            nonVisualPictureProperties3.Append(nonVisualDrawingProperties4);
            nonVisualPictureProperties3.Append(nonVisualPictureDrawingProperties3);
            nonVisualPictureProperties3.Append(applicationNonVisualDrawingProperties4);

            BlipFill blipFill3 = new BlipFill();

            A.Blip blip3 = new A.Blip() { Embed = "rId4" };

            A.BlipExtensionList blipExtensionList3 = new A.BlipExtensionList();

            A.BlipExtension blipExtension3 = new A.BlipExtension() { Uri = "{28A0092B-C50C-407E-A947-70E740481C1C}" };

            A14.UseLocalDpi useLocalDpi3 = new A14.UseLocalDpi() { Val = false };
            useLocalDpi3.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            blipExtension3.Append(useLocalDpi3);

            blipExtensionList3.Append(blipExtension3);

            blip3.Append(blipExtensionList3);

            A.Stretch stretch3 = new A.Stretch();
            A.FillRectangle fillRectangle3 = new A.FillRectangle();

            stretch3.Append(fillRectangle3);

            blipFill3.Append(blip3);
            blipFill3.Append(stretch3);

            ShapeProperties shapeProperties3 = new ShapeProperties();

            A.Transform2D transform2D3 = new A.Transform2D();
            A.Offset offset4 = new A.Offset() { X = 8327821L, Y = 0L };
            A.Extents extents4 = new A.Extents() { Cx = 10287000L, Cy = 6858000L };

            transform2D3.Append(offset4);
            transform2D3.Append(extents4);

            A.PresetGeometry presetGeometry3 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList3 = new A.AdjustValueList();

            presetGeometry3.Append(adjustValueList3);

            shapeProperties3.Append(transform2D3);
            shapeProperties3.Append(presetGeometry3);

            picture3.Append(nonVisualPictureProperties3);
            picture3.Append(blipFill3);
            picture3.Append(shapeProperties3);

            Shape shape1 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties1 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties5 = new NonVisualDrawingProperties() { Id = (UInt32Value)2U, Name = "Title 1" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList4 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension4 = new A.NonVisualDrawingPropertiesExtension() { Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement4 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{E2F2E5CB-59A4-42EA-974E-78DB1807BF05}\" />");

            nonVisualDrawingPropertiesExtension4.Append(openXmlUnknownElement4);

            nonVisualDrawingPropertiesExtensionList4.Append(nonVisualDrawingPropertiesExtension4);

            nonVisualDrawingProperties5.Append(nonVisualDrawingPropertiesExtensionList4);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties1 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks1 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties1.Append(shapeLocks1);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties5 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape1 = new PlaceholderShape() { Type = PlaceholderValues.CenteredTitle };

            applicationNonVisualDrawingProperties5.Append(placeholderShape1);

            nonVisualShapeProperties1.Append(nonVisualDrawingProperties5);
            nonVisualShapeProperties1.Append(nonVisualShapeDrawingProperties1);
            nonVisualShapeProperties1.Append(applicationNonVisualDrawingProperties5);
            ShapeProperties shapeProperties4 = new ShapeProperties();

            TextBody textBody1 = new TextBody();
            A.BodyProperties bodyProperties1 = new A.BodyProperties();
            A.ListStyle listStyle1 = new A.ListStyle();

            A.Paragraph paragraph1 = new A.Paragraph();

            A.Run run1 = new A.Run();
            A.RunProperties runProperties1 = new A.RunProperties() { Language = "en-US", Dirty = false };
            A.Text text1 = new A.Text();
            text1.Text = _inputTitle;

            run1.Append(runProperties1);
            run1.Append(text1);

            paragraph1.Append(run1);

            textBody1.Append(bodyProperties1);
            textBody1.Append(listStyle1);
            textBody1.Append(paragraph1);

            shape1.Append(nonVisualShapeProperties1);
            shape1.Append(shapeProperties4);
            shape1.Append(textBody1);

            Shape shape2 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties2 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties6 = new NonVisualDrawingProperties() { Id = (UInt32Value)3U, Name = "Subtitle 2" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList5 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension5 = new A.NonVisualDrawingPropertiesExtension() { Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement5 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{A6DE7513-0F55-4513-B783-C0E3F97A22C9}\" />");

            nonVisualDrawingPropertiesExtension5.Append(openXmlUnknownElement5);

            nonVisualDrawingPropertiesExtensionList5.Append(nonVisualDrawingPropertiesExtension5);

            nonVisualDrawingProperties6.Append(nonVisualDrawingPropertiesExtensionList5);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties2 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks2 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties2.Append(shapeLocks2);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties6 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape2 = new PlaceholderShape() { Type = PlaceholderValues.SubTitle, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties6.Append(placeholderShape2);

            nonVisualShapeProperties2.Append(nonVisualDrawingProperties6);
            nonVisualShapeProperties2.Append(nonVisualShapeDrawingProperties2);
            nonVisualShapeProperties2.Append(applicationNonVisualDrawingProperties6);
            ShapeProperties shapeProperties5 = new ShapeProperties();

            TextBody textBody2 = new TextBody();
            A.BodyProperties bodyProperties2 = new A.BodyProperties();
            A.ListStyle listStyle2 = new A.ListStyle();

            A.Paragraph paragraph2 = new A.Paragraph();

            A.Run run2 = new A.Run();
            A.RunProperties runProperties2 = new A.RunProperties() { Language = "en-US", Dirty = false };
            A.Text text2 = new A.Text();
            text2.Text = _inputBody;

            run2.Append(runProperties2);
            run2.Append(text2);

            paragraph2.Append(run2);

            textBody2.Append(bodyProperties2);
            textBody2.Append(listStyle2);
            textBody2.Append(paragraph2);

            shape2.Append(nonVisualShapeProperties2);
            shape2.Append(shapeProperties5);
            shape2.Append(textBody2);

            shapeTree1.Append(nonVisualGroupShapeProperties1);
            shapeTree1.Append(groupShapeProperties1);
            shapeTree1.Append(picture1);
            shapeTree1.Append(picture2);
            shapeTree1.Append(picture3);
            shapeTree1.Append(shape1);
            shapeTree1.Append(shape2);

            CommonSlideDataExtensionList commonSlideDataExtensionList1 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension1 = new CommonSlideDataExtension() { Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId1 = new P14.CreationId() { Val = (UInt32Value)3486108249U };
            creationId1.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension1.Append(creationId1);

            commonSlideDataExtensionList1.Append(commonSlideDataExtension1);

            commonSlideData1.Append(shapeTree1);
            commonSlideData1.Append(commonSlideDataExtensionList1);

            ColorMapOverride colorMapOverride1 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping1 = new A.MasterColorMapping();

            colorMapOverride1.Append(masterColorMapping1);

            slide1.Append(commonSlideData1);
            slide1.Append(colorMapOverride1);

            slidePart1.Slide = slide1;
        }

        // Generates content of imagePart1.
        private void GenerateImagePart1Content(ImagePart imagePart1)
        {
            //SERIALIZE
            System.IO.Stream data = GetBinaryDataStream(_image1);
            imagePart1.FeedData(data);
            data.Close();
        }

        // Generates content of imagePart2.
        private void GenerateImagePart2Content(ImagePart imagePart2)
        {
            System.IO.Stream data = GetBinaryDataStream(_image2);
            imagePart2.FeedData(data);
            data.Close();
        }

        // Generates content of slideLayoutPart1.
        private void GenerateSlideLayoutPart1Content(SlideLayoutPart slideLayoutPart1)
        {
            SlideLayout slideLayout1 = new SlideLayout() { Type = SlideLayoutValues.Title, Preserve = true };
            slideLayout1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData2 = new CommonSlideData() { Name = "Title Slide" };

            ShapeTree shapeTree2 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties2 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties7 = new NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties2 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties7 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties2.Append(nonVisualDrawingProperties7);
            nonVisualGroupShapeProperties2.Append(nonVisualGroupShapeDrawingProperties2);
            nonVisualGroupShapeProperties2.Append(applicationNonVisualDrawingProperties7);

            GroupShapeProperties groupShapeProperties2 = new GroupShapeProperties();

            A.TransformGroup transformGroup2 = new A.TransformGroup();
            A.Offset offset5 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents5 = new A.Extents() { Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset2 = new A.ChildOffset() { X = 0L, Y = 0L };
            A.ChildExtents childExtents2 = new A.ChildExtents() { Cx = 0L, Cy = 0L };

            transformGroup2.Append(offset5);
            transformGroup2.Append(extents5);
            transformGroup2.Append(childOffset2);
            transformGroup2.Append(childExtents2);

            groupShapeProperties2.Append(transformGroup2);

            Shape shape3 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties3 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties8 = new NonVisualDrawingProperties() { Id = (UInt32Value)2U, Name = "Title 1" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList6 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension6 = new A.NonVisualDrawingPropertiesExtension() { Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement6 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{55488A45-AE25-41AB-84C6-E143EEE61428}\" />");

            nonVisualDrawingPropertiesExtension6.Append(openXmlUnknownElement6);

            nonVisualDrawingPropertiesExtensionList6.Append(nonVisualDrawingPropertiesExtension6);

            nonVisualDrawingProperties8.Append(nonVisualDrawingPropertiesExtensionList6);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties3 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks3 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties3.Append(shapeLocks3);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties8 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape3 = new PlaceholderShape() { Type = PlaceholderValues.CenteredTitle };

            applicationNonVisualDrawingProperties8.Append(placeholderShape3);

            nonVisualShapeProperties3.Append(nonVisualDrawingProperties8);
            nonVisualShapeProperties3.Append(nonVisualShapeDrawingProperties3);
            nonVisualShapeProperties3.Append(applicationNonVisualDrawingProperties8);

            ShapeProperties shapeProperties6 = new ShapeProperties();

            A.Transform2D transform2D4 = new A.Transform2D();
            A.Offset offset6 = new A.Offset() { X = 1524000L, Y = 1122363L };
            A.Extents extents6 = new A.Extents() { Cx = 9144000L, Cy = 2387600L };

            transform2D4.Append(offset6);
            transform2D4.Append(extents6);

            A.PresetGeometry presetGeometry4 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList4 = new A.AdjustValueList();

            presetGeometry4.Append(adjustValueList4);

            shapeProperties6.Append(transform2D4);
            shapeProperties6.Append(presetGeometry4);

            TextBody textBody3 = new TextBody();
            A.BodyProperties bodyProperties3 = new A.BodyProperties() { Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle3 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties2 = new A.Level1ParagraphProperties() { Alignment = A.TextAlignmentTypeValues.Center };
            A.DefaultRunProperties defaultRunProperties11 = new A.DefaultRunProperties() { FontSize = 6000 };

            level1ParagraphProperties2.Append(defaultRunProperties11);

            listStyle3.Append(level1ParagraphProperties2);

            A.Paragraph paragraph3 = new A.Paragraph();

            A.Run run3 = new A.Run();
            A.RunProperties runProperties3 = new A.RunProperties() { Language = "en-US" };
            A.Text text3 = new A.Text();
            text3.Text = "Click to edit Master title style";

            run3.Append(runProperties3);
            run3.Append(text3);

            paragraph3.Append(run3);

            textBody3.Append(bodyProperties3);
            textBody3.Append(listStyle3);
            textBody3.Append(paragraph3);

            shape3.Append(nonVisualShapeProperties3);
            shape3.Append(shapeProperties6);
            shape3.Append(textBody3);

            Shape shape4 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties4 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties9 = new NonVisualDrawingProperties() { Id = (UInt32Value)3U, Name = "Subtitle 2" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList7 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension7 = new A.NonVisualDrawingPropertiesExtension() { Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement7 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{5538BA16-C4B8-43CF-B36C-A6A38C46CCD7}\" />");

            nonVisualDrawingPropertiesExtension7.Append(openXmlUnknownElement7);

            nonVisualDrawingPropertiesExtensionList7.Append(nonVisualDrawingPropertiesExtension7);

            nonVisualDrawingProperties9.Append(nonVisualDrawingPropertiesExtensionList7);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties4 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks4 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties4.Append(shapeLocks4);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties9 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape4 = new PlaceholderShape() { Type = PlaceholderValues.SubTitle, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties9.Append(placeholderShape4);

            nonVisualShapeProperties4.Append(nonVisualDrawingProperties9);
            nonVisualShapeProperties4.Append(nonVisualShapeDrawingProperties4);
            nonVisualShapeProperties4.Append(applicationNonVisualDrawingProperties9);

            ShapeProperties shapeProperties7 = new ShapeProperties();

            A.Transform2D transform2D5 = new A.Transform2D();
            A.Offset offset7 = new A.Offset() { X = 1524000L, Y = 3602038L };
            A.Extents extents7 = new A.Extents() { Cx = 9144000L, Cy = 1655762L };

            transform2D5.Append(offset7);
            transform2D5.Append(extents7);

            A.PresetGeometry presetGeometry5 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList5 = new A.AdjustValueList();

            presetGeometry5.Append(adjustValueList5);

            shapeProperties7.Append(transform2D5);
            shapeProperties7.Append(presetGeometry5);

            TextBody textBody4 = new TextBody();
            A.BodyProperties bodyProperties4 = new A.BodyProperties();

            A.ListStyle listStyle4 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties3 = new A.Level1ParagraphProperties() { LeftMargin = 0, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet1 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties12 = new A.DefaultRunProperties() { FontSize = 2400 };

            level1ParagraphProperties3.Append(noBullet1);
            level1ParagraphProperties3.Append(defaultRunProperties12);

            A.Level2ParagraphProperties level2ParagraphProperties2 = new A.Level2ParagraphProperties() { LeftMargin = 457200, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet2 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties13 = new A.DefaultRunProperties() { FontSize = 2000 };

            level2ParagraphProperties2.Append(noBullet2);
            level2ParagraphProperties2.Append(defaultRunProperties13);

            A.Level3ParagraphProperties level3ParagraphProperties2 = new A.Level3ParagraphProperties() { LeftMargin = 914400, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet3 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties14 = new A.DefaultRunProperties() { FontSize = 1800 };

            level3ParagraphProperties2.Append(noBullet3);
            level3ParagraphProperties2.Append(defaultRunProperties14);

            A.Level4ParagraphProperties level4ParagraphProperties2 = new A.Level4ParagraphProperties() { LeftMargin = 1371600, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet4 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties15 = new A.DefaultRunProperties() { FontSize = 1600 };

            level4ParagraphProperties2.Append(noBullet4);
            level4ParagraphProperties2.Append(defaultRunProperties15);

            A.Level5ParagraphProperties level5ParagraphProperties2 = new A.Level5ParagraphProperties() { LeftMargin = 1828800, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet5 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties16 = new A.DefaultRunProperties() { FontSize = 1600 };

            level5ParagraphProperties2.Append(noBullet5);
            level5ParagraphProperties2.Append(defaultRunProperties16);

            A.Level6ParagraphProperties level6ParagraphProperties2 = new A.Level6ParagraphProperties() { LeftMargin = 2286000, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet6 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties17 = new A.DefaultRunProperties() { FontSize = 1600 };

            level6ParagraphProperties2.Append(noBullet6);
            level6ParagraphProperties2.Append(defaultRunProperties17);

            A.Level7ParagraphProperties level7ParagraphProperties2 = new A.Level7ParagraphProperties() { LeftMargin = 2743200, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet7 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties18 = new A.DefaultRunProperties() { FontSize = 1600 };

            level7ParagraphProperties2.Append(noBullet7);
            level7ParagraphProperties2.Append(defaultRunProperties18);

            A.Level8ParagraphProperties level8ParagraphProperties2 = new A.Level8ParagraphProperties() { LeftMargin = 3200400, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet8 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties19 = new A.DefaultRunProperties() { FontSize = 1600 };

            level8ParagraphProperties2.Append(noBullet8);
            level8ParagraphProperties2.Append(defaultRunProperties19);

            A.Level9ParagraphProperties level9ParagraphProperties2 = new A.Level9ParagraphProperties() { LeftMargin = 3657600, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet9 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties20 = new A.DefaultRunProperties() { FontSize = 1600 };

            level9ParagraphProperties2.Append(noBullet9);
            level9ParagraphProperties2.Append(defaultRunProperties20);

            listStyle4.Append(level1ParagraphProperties3);
            listStyle4.Append(level2ParagraphProperties2);
            listStyle4.Append(level3ParagraphProperties2);
            listStyle4.Append(level4ParagraphProperties2);
            listStyle4.Append(level5ParagraphProperties2);
            listStyle4.Append(level6ParagraphProperties2);
            listStyle4.Append(level7ParagraphProperties2);
            listStyle4.Append(level8ParagraphProperties2);
            listStyle4.Append(level9ParagraphProperties2);

            A.Paragraph paragraph4 = new A.Paragraph();

            A.Run run4 = new A.Run();
            A.RunProperties runProperties4 = new A.RunProperties() { Language = "en-US" };
            A.Text text4 = new A.Text();
            text4.Text = "Click to edit Master subtitle style";

            run4.Append(runProperties4);
            run4.Append(text4);

            paragraph4.Append(run4);

            textBody4.Append(bodyProperties4);
            textBody4.Append(listStyle4);
            textBody4.Append(paragraph4);

            shape4.Append(nonVisualShapeProperties4);
            shape4.Append(shapeProperties7);
            shape4.Append(textBody4);

            shapeTree2.Append(nonVisualGroupShapeProperties2);
            shapeTree2.Append(groupShapeProperties2);
            shapeTree2.Append(shape3);
            shapeTree2.Append(shape4);

            CommonSlideDataExtensionList commonSlideDataExtensionList2 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension2 = new CommonSlideDataExtension() { Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId2 = new P14.CreationId() { Val = (UInt32Value)4263777232U };
            creationId2.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension2.Append(creationId2);

            commonSlideDataExtensionList2.Append(commonSlideDataExtension2);

            commonSlideData2.Append(shapeTree2);
            commonSlideData2.Append(commonSlideDataExtensionList2);

            ColorMapOverride colorMapOverride2 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping2 = new A.MasterColorMapping();

            colorMapOverride2.Append(masterColorMapping2);

            slideLayout1.Append(commonSlideData2);
            slideLayout1.Append(colorMapOverride2);

            slideLayoutPart1.SlideLayout = slideLayout1;
        }

        // Generates content of slideMasterPart1.
        private void GenerateSlideMasterPart1Content(SlideMasterPart slideMasterPart1)
        {
            SlideMaster slideMaster1 = new SlideMaster();
            slideMaster1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideMaster1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideMaster1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData3 = new CommonSlideData();

            Background background1 = new Background();

            BackgroundStyleReference backgroundStyleReference1 = new BackgroundStyleReference() { Index = (UInt32Value)1001U };
            A.SchemeColor schemeColor10 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            backgroundStyleReference1.Append(schemeColor10);

            background1.Append(backgroundStyleReference1);

            ShapeTree shapeTree3 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties3 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties10 = new NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties3 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties10 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties3.Append(nonVisualDrawingProperties10);
            nonVisualGroupShapeProperties3.Append(nonVisualGroupShapeDrawingProperties3);
            nonVisualGroupShapeProperties3.Append(applicationNonVisualDrawingProperties10);

            GroupShapeProperties groupShapeProperties3 = new GroupShapeProperties();

            A.TransformGroup transformGroup3 = new A.TransformGroup();
            A.Offset offset8 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents8 = new A.Extents() { Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset3 = new A.ChildOffset() { X = 0L, Y = 0L };
            A.ChildExtents childExtents3 = new A.ChildExtents() { Cx = 0L, Cy = 0L };

            transformGroup3.Append(offset8);
            transformGroup3.Append(extents8);
            transformGroup3.Append(childOffset3);
            transformGroup3.Append(childExtents3);

            groupShapeProperties3.Append(transformGroup3);

            shapeTree3.Append(nonVisualGroupShapeProperties3);
            shapeTree3.Append(groupShapeProperties3);

            CommonSlideDataExtensionList commonSlideDataExtensionList3 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension3 = new CommonSlideDataExtension() { Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId3 = new P14.CreationId() { Val = (UInt32Value)849159862U };
            creationId3.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension3.Append(creationId3);

            commonSlideDataExtensionList3.Append(commonSlideDataExtension3);

            commonSlideData3.Append(background1);
            commonSlideData3.Append(shapeTree3);
            commonSlideData3.Append(commonSlideDataExtensionList3);
            ColorMap colorMap1 = new ColorMap() { Background1 = A.ColorSchemeIndexValues.Light1, Text1 = A.ColorSchemeIndexValues.Dark1, Background2 = A.ColorSchemeIndexValues.Light2, Text2 = A.ColorSchemeIndexValues.Dark2, Accent1 = A.ColorSchemeIndexValues.Accent1, Accent2 = A.ColorSchemeIndexValues.Accent2, Accent3 = A.ColorSchemeIndexValues.Accent3, Accent4 = A.ColorSchemeIndexValues.Accent4, Accent5 = A.ColorSchemeIndexValues.Accent5, Accent6 = A.ColorSchemeIndexValues.Accent6, Hyperlink = A.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = A.ColorSchemeIndexValues.FollowedHyperlink };

            SlideLayoutIdList slideLayoutIdList1 = new SlideLayoutIdList();
            SlideLayoutId slideLayoutId1 = new SlideLayoutId() { Id = (UInt32Value)2147483649U, RelationshipId = "rId1" };

            slideLayoutIdList1.Append(slideLayoutId1);

            TextStyles textStyles1 = new TextStyles();

            TitleStyle titleStyle1 = new TitleStyle();

            A.Level1ParagraphProperties level1ParagraphProperties4 = new A.Level1ParagraphProperties() { Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.LineSpacing lineSpacing1 = new A.LineSpacing();
            A.SpacingPercent spacingPercent1 = new A.SpacingPercent() { Val = 90000 };

            lineSpacing1.Append(spacingPercent1);

            A.SpaceBefore spaceBefore1 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent2 = new A.SpacingPercent() { Val = 0 };

            spaceBefore1.Append(spacingPercent2);
            A.NoBullet noBullet10 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties21 = new A.DefaultRunProperties() { FontSize = 4400, Kerning = 1200 };

            A.SolidFill solidFill10 = new A.SolidFill();
            A.SchemeColor schemeColor11 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill10.Append(schemeColor11);
            A.LatinFont latinFont10 = new A.LatinFont() { Typeface = "+mj-lt" };
            A.EastAsianFont eastAsianFont10 = new A.EastAsianFont() { Typeface = "+mj-ea" };
            A.ComplexScriptFont complexScriptFont10 = new A.ComplexScriptFont() { Typeface = "+mj-cs" };

            defaultRunProperties21.Append(solidFill10);
            defaultRunProperties21.Append(latinFont10);
            defaultRunProperties21.Append(eastAsianFont10);
            defaultRunProperties21.Append(complexScriptFont10);

            level1ParagraphProperties4.Append(lineSpacing1);
            level1ParagraphProperties4.Append(spaceBefore1);
            level1ParagraphProperties4.Append(noBullet10);
            level1ParagraphProperties4.Append(defaultRunProperties21);

            titleStyle1.Append(level1ParagraphProperties4);

            BodyStyle bodyStyle1 = new BodyStyle();

            A.Level1ParagraphProperties level1ParagraphProperties5 = new A.Level1ParagraphProperties() { LeftMargin = 228600, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.LineSpacing lineSpacing2 = new A.LineSpacing();
            A.SpacingPercent spacingPercent3 = new A.SpacingPercent() { Val = 90000 };

            lineSpacing2.Append(spacingPercent3);

            A.SpaceBefore spaceBefore2 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints1 = new A.SpacingPoints() { Val = 1000 };

            spaceBefore2.Append(spacingPoints1);
            A.BulletFont bulletFont1 = new A.BulletFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet1 = new A.CharacterBullet() { Char = "•" };

            A.DefaultRunProperties defaultRunProperties22 = new A.DefaultRunProperties() { FontSize = 2800, Kerning = 1200 };

            A.SolidFill solidFill11 = new A.SolidFill();
            A.SchemeColor schemeColor12 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill11.Append(schemeColor12);
            A.LatinFont latinFont11 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont11 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont11 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties22.Append(solidFill11);
            defaultRunProperties22.Append(latinFont11);
            defaultRunProperties22.Append(eastAsianFont11);
            defaultRunProperties22.Append(complexScriptFont11);

            level1ParagraphProperties5.Append(lineSpacing2);
            level1ParagraphProperties5.Append(spaceBefore2);
            level1ParagraphProperties5.Append(bulletFont1);
            level1ParagraphProperties5.Append(characterBullet1);
            level1ParagraphProperties5.Append(defaultRunProperties22);

            A.Level2ParagraphProperties level2ParagraphProperties3 = new A.Level2ParagraphProperties() { LeftMargin = 685800, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.LineSpacing lineSpacing3 = new A.LineSpacing();
            A.SpacingPercent spacingPercent4 = new A.SpacingPercent() { Val = 90000 };

            lineSpacing3.Append(spacingPercent4);

            A.SpaceBefore spaceBefore3 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints2 = new A.SpacingPoints() { Val = 500 };

            spaceBefore3.Append(spacingPoints2);
            A.BulletFont bulletFont2 = new A.BulletFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet2 = new A.CharacterBullet() { Char = "•" };

            A.DefaultRunProperties defaultRunProperties23 = new A.DefaultRunProperties() { FontSize = 2400, Kerning = 1200 };

            A.SolidFill solidFill12 = new A.SolidFill();
            A.SchemeColor schemeColor13 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill12.Append(schemeColor13);
            A.LatinFont latinFont12 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont12 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont12 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties23.Append(solidFill12);
            defaultRunProperties23.Append(latinFont12);
            defaultRunProperties23.Append(eastAsianFont12);
            defaultRunProperties23.Append(complexScriptFont12);

            level2ParagraphProperties3.Append(lineSpacing3);
            level2ParagraphProperties3.Append(spaceBefore3);
            level2ParagraphProperties3.Append(bulletFont2);
            level2ParagraphProperties3.Append(characterBullet2);
            level2ParagraphProperties3.Append(defaultRunProperties23);

            A.Level3ParagraphProperties level3ParagraphProperties3 = new A.Level3ParagraphProperties() { LeftMargin = 1143000, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.LineSpacing lineSpacing4 = new A.LineSpacing();
            A.SpacingPercent spacingPercent5 = new A.SpacingPercent() { Val = 90000 };

            lineSpacing4.Append(spacingPercent5);

            A.SpaceBefore spaceBefore4 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints3 = new A.SpacingPoints() { Val = 500 };

            spaceBefore4.Append(spacingPoints3);
            A.BulletFont bulletFont3 = new A.BulletFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet3 = new A.CharacterBullet() { Char = "•" };

            A.DefaultRunProperties defaultRunProperties24 = new A.DefaultRunProperties() { FontSize = 2000, Kerning = 1200 };

            A.SolidFill solidFill13 = new A.SolidFill();
            A.SchemeColor schemeColor14 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill13.Append(schemeColor14);
            A.LatinFont latinFont13 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont13 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont13 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties24.Append(solidFill13);
            defaultRunProperties24.Append(latinFont13);
            defaultRunProperties24.Append(eastAsianFont13);
            defaultRunProperties24.Append(complexScriptFont13);

            level3ParagraphProperties3.Append(lineSpacing4);
            level3ParagraphProperties3.Append(spaceBefore4);
            level3ParagraphProperties3.Append(bulletFont3);
            level3ParagraphProperties3.Append(characterBullet3);
            level3ParagraphProperties3.Append(defaultRunProperties24);

            A.Level4ParagraphProperties level4ParagraphProperties3 = new A.Level4ParagraphProperties() { LeftMargin = 1600200, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.LineSpacing lineSpacing5 = new A.LineSpacing();
            A.SpacingPercent spacingPercent6 = new A.SpacingPercent() { Val = 90000 };

            lineSpacing5.Append(spacingPercent6);

            A.SpaceBefore spaceBefore5 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints4 = new A.SpacingPoints() { Val = 500 };

            spaceBefore5.Append(spacingPoints4);
            A.BulletFont bulletFont4 = new A.BulletFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet4 = new A.CharacterBullet() { Char = "•" };

            A.DefaultRunProperties defaultRunProperties25 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill14 = new A.SolidFill();
            A.SchemeColor schemeColor15 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill14.Append(schemeColor15);
            A.LatinFont latinFont14 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont14 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont14 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties25.Append(solidFill14);
            defaultRunProperties25.Append(latinFont14);
            defaultRunProperties25.Append(eastAsianFont14);
            defaultRunProperties25.Append(complexScriptFont14);

            level4ParagraphProperties3.Append(lineSpacing5);
            level4ParagraphProperties3.Append(spaceBefore5);
            level4ParagraphProperties3.Append(bulletFont4);
            level4ParagraphProperties3.Append(characterBullet4);
            level4ParagraphProperties3.Append(defaultRunProperties25);

            A.Level5ParagraphProperties level5ParagraphProperties3 = new A.Level5ParagraphProperties() { LeftMargin = 2057400, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.LineSpacing lineSpacing6 = new A.LineSpacing();
            A.SpacingPercent spacingPercent7 = new A.SpacingPercent() { Val = 90000 };

            lineSpacing6.Append(spacingPercent7);

            A.SpaceBefore spaceBefore6 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints5 = new A.SpacingPoints() { Val = 500 };

            spaceBefore6.Append(spacingPoints5);
            A.BulletFont bulletFont5 = new A.BulletFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet5 = new A.CharacterBullet() { Char = "•" };

            A.DefaultRunProperties defaultRunProperties26 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill15 = new A.SolidFill();
            A.SchemeColor schemeColor16 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill15.Append(schemeColor16);
            A.LatinFont latinFont15 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont15 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont15 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties26.Append(solidFill15);
            defaultRunProperties26.Append(latinFont15);
            defaultRunProperties26.Append(eastAsianFont15);
            defaultRunProperties26.Append(complexScriptFont15);

            level5ParagraphProperties3.Append(lineSpacing6);
            level5ParagraphProperties3.Append(spaceBefore6);
            level5ParagraphProperties3.Append(bulletFont5);
            level5ParagraphProperties3.Append(characterBullet5);
            level5ParagraphProperties3.Append(defaultRunProperties26);

            A.Level6ParagraphProperties level6ParagraphProperties3 = new A.Level6ParagraphProperties() { LeftMargin = 2514600, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.LineSpacing lineSpacing7 = new A.LineSpacing();
            A.SpacingPercent spacingPercent8 = new A.SpacingPercent() { Val = 90000 };

            lineSpacing7.Append(spacingPercent8);

            A.SpaceBefore spaceBefore7 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints6 = new A.SpacingPoints() { Val = 500 };

            spaceBefore7.Append(spacingPoints6);
            A.BulletFont bulletFont6 = new A.BulletFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet6 = new A.CharacterBullet() { Char = "•" };

            A.DefaultRunProperties defaultRunProperties27 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill16 = new A.SolidFill();
            A.SchemeColor schemeColor17 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill16.Append(schemeColor17);
            A.LatinFont latinFont16 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont16 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont16 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties27.Append(solidFill16);
            defaultRunProperties27.Append(latinFont16);
            defaultRunProperties27.Append(eastAsianFont16);
            defaultRunProperties27.Append(complexScriptFont16);

            level6ParagraphProperties3.Append(lineSpacing7);
            level6ParagraphProperties3.Append(spaceBefore7);
            level6ParagraphProperties3.Append(bulletFont6);
            level6ParagraphProperties3.Append(characterBullet6);
            level6ParagraphProperties3.Append(defaultRunProperties27);

            A.Level7ParagraphProperties level7ParagraphProperties3 = new A.Level7ParagraphProperties() { LeftMargin = 2971800, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.LineSpacing lineSpacing8 = new A.LineSpacing();
            A.SpacingPercent spacingPercent9 = new A.SpacingPercent() { Val = 90000 };

            lineSpacing8.Append(spacingPercent9);

            A.SpaceBefore spaceBefore8 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints7 = new A.SpacingPoints() { Val = 500 };

            spaceBefore8.Append(spacingPoints7);
            A.BulletFont bulletFont7 = new A.BulletFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet7 = new A.CharacterBullet() { Char = "•" };

            A.DefaultRunProperties defaultRunProperties28 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill17 = new A.SolidFill();
            A.SchemeColor schemeColor18 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill17.Append(schemeColor18);
            A.LatinFont latinFont17 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont17 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont17 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties28.Append(solidFill17);
            defaultRunProperties28.Append(latinFont17);
            defaultRunProperties28.Append(eastAsianFont17);
            defaultRunProperties28.Append(complexScriptFont17);

            level7ParagraphProperties3.Append(lineSpacing8);
            level7ParagraphProperties3.Append(spaceBefore8);
            level7ParagraphProperties3.Append(bulletFont7);
            level7ParagraphProperties3.Append(characterBullet7);
            level7ParagraphProperties3.Append(defaultRunProperties28);

            A.Level8ParagraphProperties level8ParagraphProperties3 = new A.Level8ParagraphProperties() { LeftMargin = 3429000, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.LineSpacing lineSpacing9 = new A.LineSpacing();
            A.SpacingPercent spacingPercent10 = new A.SpacingPercent() { Val = 90000 };

            lineSpacing9.Append(spacingPercent10);

            A.SpaceBefore spaceBefore9 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints8 = new A.SpacingPoints() { Val = 500 };

            spaceBefore9.Append(spacingPoints8);
            A.BulletFont bulletFont8 = new A.BulletFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet8 = new A.CharacterBullet() { Char = "•" };

            A.DefaultRunProperties defaultRunProperties29 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill18 = new A.SolidFill();
            A.SchemeColor schemeColor19 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill18.Append(schemeColor19);
            A.LatinFont latinFont18 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont18 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont18 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties29.Append(solidFill18);
            defaultRunProperties29.Append(latinFont18);
            defaultRunProperties29.Append(eastAsianFont18);
            defaultRunProperties29.Append(complexScriptFont18);

            level8ParagraphProperties3.Append(lineSpacing9);
            level8ParagraphProperties3.Append(spaceBefore9);
            level8ParagraphProperties3.Append(bulletFont8);
            level8ParagraphProperties3.Append(characterBullet8);
            level8ParagraphProperties3.Append(defaultRunProperties29);

            A.Level9ParagraphProperties level9ParagraphProperties3 = new A.Level9ParagraphProperties() { LeftMargin = 3886200, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.LineSpacing lineSpacing10 = new A.LineSpacing();
            A.SpacingPercent spacingPercent11 = new A.SpacingPercent() { Val = 90000 };

            lineSpacing10.Append(spacingPercent11);

            A.SpaceBefore spaceBefore10 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints9 = new A.SpacingPoints() { Val = 500 };

            spaceBefore10.Append(spacingPoints9);
            A.BulletFont bulletFont9 = new A.BulletFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet9 = new A.CharacterBullet() { Char = "•" };

            A.DefaultRunProperties defaultRunProperties30 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill19 = new A.SolidFill();
            A.SchemeColor schemeColor20 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill19.Append(schemeColor20);
            A.LatinFont latinFont19 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont19 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont19 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties30.Append(solidFill19);
            defaultRunProperties30.Append(latinFont19);
            defaultRunProperties30.Append(eastAsianFont19);
            defaultRunProperties30.Append(complexScriptFont19);

            level9ParagraphProperties3.Append(lineSpacing10);
            level9ParagraphProperties3.Append(spaceBefore10);
            level9ParagraphProperties3.Append(bulletFont9);
            level9ParagraphProperties3.Append(characterBullet9);
            level9ParagraphProperties3.Append(defaultRunProperties30);

            bodyStyle1.Append(level1ParagraphProperties5);
            bodyStyle1.Append(level2ParagraphProperties3);
            bodyStyle1.Append(level3ParagraphProperties3);
            bodyStyle1.Append(level4ParagraphProperties3);
            bodyStyle1.Append(level5ParagraphProperties3);
            bodyStyle1.Append(level6ParagraphProperties3);
            bodyStyle1.Append(level7ParagraphProperties3);
            bodyStyle1.Append(level8ParagraphProperties3);
            bodyStyle1.Append(level9ParagraphProperties3);

            OtherStyle otherStyle1 = new OtherStyle();

            A.DefaultParagraphProperties defaultParagraphProperties2 = new A.DefaultParagraphProperties();
            A.DefaultRunProperties defaultRunProperties31 = new A.DefaultRunProperties() { Language = "en-US" };

            defaultParagraphProperties2.Append(defaultRunProperties31);

            A.Level1ParagraphProperties level1ParagraphProperties6 = new A.Level1ParagraphProperties() { LeftMargin = 0, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties32 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill20 = new A.SolidFill();
            A.SchemeColor schemeColor21 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill20.Append(schemeColor21);
            A.LatinFont latinFont20 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont20 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont20 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties32.Append(solidFill20);
            defaultRunProperties32.Append(latinFont20);
            defaultRunProperties32.Append(eastAsianFont20);
            defaultRunProperties32.Append(complexScriptFont20);

            level1ParagraphProperties6.Append(defaultRunProperties32);

            A.Level2ParagraphProperties level2ParagraphProperties4 = new A.Level2ParagraphProperties() { LeftMargin = 457200, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties33 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill21 = new A.SolidFill();
            A.SchemeColor schemeColor22 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill21.Append(schemeColor22);
            A.LatinFont latinFont21 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont21 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont21 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties33.Append(solidFill21);
            defaultRunProperties33.Append(latinFont21);
            defaultRunProperties33.Append(eastAsianFont21);
            defaultRunProperties33.Append(complexScriptFont21);

            level2ParagraphProperties4.Append(defaultRunProperties33);

            A.Level3ParagraphProperties level3ParagraphProperties4 = new A.Level3ParagraphProperties() { LeftMargin = 914400, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties34 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill22 = new A.SolidFill();
            A.SchemeColor schemeColor23 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill22.Append(schemeColor23);
            A.LatinFont latinFont22 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont22 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont22 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties34.Append(solidFill22);
            defaultRunProperties34.Append(latinFont22);
            defaultRunProperties34.Append(eastAsianFont22);
            defaultRunProperties34.Append(complexScriptFont22);

            level3ParagraphProperties4.Append(defaultRunProperties34);

            A.Level4ParagraphProperties level4ParagraphProperties4 = new A.Level4ParagraphProperties() { LeftMargin = 1371600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties35 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill23 = new A.SolidFill();
            A.SchemeColor schemeColor24 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill23.Append(schemeColor24);
            A.LatinFont latinFont23 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont23 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont23 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties35.Append(solidFill23);
            defaultRunProperties35.Append(latinFont23);
            defaultRunProperties35.Append(eastAsianFont23);
            defaultRunProperties35.Append(complexScriptFont23);

            level4ParagraphProperties4.Append(defaultRunProperties35);

            A.Level5ParagraphProperties level5ParagraphProperties4 = new A.Level5ParagraphProperties() { LeftMargin = 1828800, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties36 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill24 = new A.SolidFill();
            A.SchemeColor schemeColor25 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill24.Append(schemeColor25);
            A.LatinFont latinFont24 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont24 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont24 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties36.Append(solidFill24);
            defaultRunProperties36.Append(latinFont24);
            defaultRunProperties36.Append(eastAsianFont24);
            defaultRunProperties36.Append(complexScriptFont24);

            level5ParagraphProperties4.Append(defaultRunProperties36);

            A.Level6ParagraphProperties level6ParagraphProperties4 = new A.Level6ParagraphProperties() { LeftMargin = 2286000, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties37 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill25 = new A.SolidFill();
            A.SchemeColor schemeColor26 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill25.Append(schemeColor26);
            A.LatinFont latinFont25 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont25 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont25 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties37.Append(solidFill25);
            defaultRunProperties37.Append(latinFont25);
            defaultRunProperties37.Append(eastAsianFont25);
            defaultRunProperties37.Append(complexScriptFont25);

            level6ParagraphProperties4.Append(defaultRunProperties37);

            A.Level7ParagraphProperties level7ParagraphProperties4 = new A.Level7ParagraphProperties() { LeftMargin = 2743200, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties38 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill26 = new A.SolidFill();
            A.SchemeColor schemeColor27 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill26.Append(schemeColor27);
            A.LatinFont latinFont26 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont26 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont26 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties38.Append(solidFill26);
            defaultRunProperties38.Append(latinFont26);
            defaultRunProperties38.Append(eastAsianFont26);
            defaultRunProperties38.Append(complexScriptFont26);

            level7ParagraphProperties4.Append(defaultRunProperties38);

            A.Level8ParagraphProperties level8ParagraphProperties4 = new A.Level8ParagraphProperties() { LeftMargin = 3200400, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties39 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill27 = new A.SolidFill();
            A.SchemeColor schemeColor28 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill27.Append(schemeColor28);
            A.LatinFont latinFont27 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont27 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont27 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties39.Append(solidFill27);
            defaultRunProperties39.Append(latinFont27);
            defaultRunProperties39.Append(eastAsianFont27);
            defaultRunProperties39.Append(complexScriptFont27);

            level8ParagraphProperties4.Append(defaultRunProperties39);

            A.Level9ParagraphProperties level9ParagraphProperties4 = new A.Level9ParagraphProperties() { LeftMargin = 3657600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties40 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill28 = new A.SolidFill();
            A.SchemeColor schemeColor29 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill28.Append(schemeColor29);
            A.LatinFont latinFont28 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont28 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont28 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties40.Append(solidFill28);
            defaultRunProperties40.Append(latinFont28);
            defaultRunProperties40.Append(eastAsianFont28);
            defaultRunProperties40.Append(complexScriptFont28);

            level9ParagraphProperties4.Append(defaultRunProperties40);

            otherStyle1.Append(defaultParagraphProperties2);
            otherStyle1.Append(level1ParagraphProperties6);
            otherStyle1.Append(level2ParagraphProperties4);
            otherStyle1.Append(level3ParagraphProperties4);
            otherStyle1.Append(level4ParagraphProperties4);
            otherStyle1.Append(level5ParagraphProperties4);
            otherStyle1.Append(level6ParagraphProperties4);
            otherStyle1.Append(level7ParagraphProperties4);
            otherStyle1.Append(level8ParagraphProperties4);
            otherStyle1.Append(level9ParagraphProperties4);

            textStyles1.Append(titleStyle1);
            textStyles1.Append(bodyStyle1);
            textStyles1.Append(otherStyle1);

            slideMaster1.Append(commonSlideData3);
            slideMaster1.Append(colorMap1);
            slideMaster1.Append(slideLayoutIdList1);
            slideMaster1.Append(textStyles1);

            slideMasterPart1.SlideMaster = slideMaster1;
        }

        // Generates content of themePart1.
        private void GenerateThemePart1Content(ThemePart themePart1)
        {
            A.Theme theme1 = new A.Theme() { Name = "Office Theme" };
            theme1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.ThemeElements themeElements1 = new A.ThemeElements();

            A.ColorScheme colorScheme1 = new A.ColorScheme() { Name = "Office" };

            A.Dark1Color dark1Color1 = new A.Dark1Color();
            A.SystemColor systemColor1 = new A.SystemColor() { Val = A.SystemColorValues.WindowText, LastColor = "000000" };

            dark1Color1.Append(systemColor1);

            A.Light1Color light1Color1 = new A.Light1Color();
            A.SystemColor systemColor2 = new A.SystemColor() { Val = A.SystemColorValues.Window, LastColor = "FFFFFF" };

            light1Color1.Append(systemColor2);

            A.Dark2Color dark2Color1 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex1 = new A.RgbColorModelHex() { Val = "44546A" };

            dark2Color1.Append(rgbColorModelHex1);

            A.Light2Color light2Color1 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex2 = new A.RgbColorModelHex() { Val = "E7E6E6" };

            light2Color1.Append(rgbColorModelHex2);

            A.Accent1Color accent1Color1 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex3 = new A.RgbColorModelHex() { Val = "4472C4" };

            accent1Color1.Append(rgbColorModelHex3);

            A.Accent2Color accent2Color1 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex4 = new A.RgbColorModelHex() { Val = "ED7D31" };

            accent2Color1.Append(rgbColorModelHex4);

            A.Accent3Color accent3Color1 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex5 = new A.RgbColorModelHex() { Val = "A5A5A5" };

            accent3Color1.Append(rgbColorModelHex5);

            A.Accent4Color accent4Color1 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex6 = new A.RgbColorModelHex() { Val = "FFC000" };

            accent4Color1.Append(rgbColorModelHex6);

            A.Accent5Color accent5Color1 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex7 = new A.RgbColorModelHex() { Val = "5B9BD5" };

            accent5Color1.Append(rgbColorModelHex7);

            A.Accent6Color accent6Color1 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex8 = new A.RgbColorModelHex() { Val = "70AD47" };

            accent6Color1.Append(rgbColorModelHex8);

            A.Hyperlink hyperlink1 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex9 = new A.RgbColorModelHex() { Val = "0563C1" };

            hyperlink1.Append(rgbColorModelHex9);

            A.FollowedHyperlinkColor followedHyperlinkColor1 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex10 = new A.RgbColorModelHex() { Val = "954F72" };

            followedHyperlinkColor1.Append(rgbColorModelHex10);

            colorScheme1.Append(dark1Color1);
            colorScheme1.Append(light1Color1);
            colorScheme1.Append(dark2Color1);
            colorScheme1.Append(light2Color1);
            colorScheme1.Append(accent1Color1);
            colorScheme1.Append(accent2Color1);
            colorScheme1.Append(accent3Color1);
            colorScheme1.Append(accent4Color1);
            colorScheme1.Append(accent5Color1);
            colorScheme1.Append(accent6Color1);
            colorScheme1.Append(hyperlink1);
            colorScheme1.Append(followedHyperlinkColor1);

            A.FontScheme fontScheme1 = new A.FontScheme() { Name = "Office" };

            A.MajorFont majorFont1 = new A.MajorFont();
            A.LatinFont latinFont29 = new A.LatinFont() { Typeface = "Calibri Light", Panose = "020F0302020204030204" };
            A.EastAsianFont eastAsianFont29 = new A.EastAsianFont() { Typeface = "" };
            A.ComplexScriptFont complexScriptFont29 = new A.ComplexScriptFont() { Typeface = "" };
            A.SupplementalFont supplementalFont1 = new A.SupplementalFont() { Script = "Jpan", Typeface = "游ゴシック Light" };
            A.SupplementalFont supplementalFont2 = new A.SupplementalFont() { Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont3 = new A.SupplementalFont() { Script = "Hans", Typeface = "等线 Light" };
            A.SupplementalFont supplementalFont4 = new A.SupplementalFont() { Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont5 = new A.SupplementalFont() { Script = "Arab", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont6 = new A.SupplementalFont() { Script = "Hebr", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont7 = new A.SupplementalFont() { Script = "Thai", Typeface = "Angsana New" };
            A.SupplementalFont supplementalFont8 = new A.SupplementalFont() { Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont9 = new A.SupplementalFont() { Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont10 = new A.SupplementalFont() { Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont11 = new A.SupplementalFont() { Script = "Khmr", Typeface = "MoolBoran" };
            A.SupplementalFont supplementalFont12 = new A.SupplementalFont() { Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont13 = new A.SupplementalFont() { Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont14 = new A.SupplementalFont() { Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont15 = new A.SupplementalFont() { Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont16 = new A.SupplementalFont() { Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont17 = new A.SupplementalFont() { Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont18 = new A.SupplementalFont() { Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont19 = new A.SupplementalFont() { Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont20 = new A.SupplementalFont() { Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont21 = new A.SupplementalFont() { Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont22 = new A.SupplementalFont() { Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont23 = new A.SupplementalFont() { Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont24 = new A.SupplementalFont() { Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont25 = new A.SupplementalFont() { Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont26 = new A.SupplementalFont() { Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont27 = new A.SupplementalFont() { Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont28 = new A.SupplementalFont() { Script = "Viet", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont29 = new A.SupplementalFont() { Script = "Uigh", Typeface = "Microsoft Uighur" };
            A.SupplementalFont supplementalFont30 = new A.SupplementalFont() { Script = "Geor", Typeface = "Sylfaen" };
            A.SupplementalFont supplementalFont31 = new A.SupplementalFont() { Script = "Armn", Typeface = "Arial" };
            A.SupplementalFont supplementalFont32 = new A.SupplementalFont() { Script = "Bugi", Typeface = "Leelawadee UI" };
            A.SupplementalFont supplementalFont33 = new A.SupplementalFont() { Script = "Bopo", Typeface = "Microsoft JhengHei" };
            A.SupplementalFont supplementalFont34 = new A.SupplementalFont() { Script = "Java", Typeface = "Javanese Text" };
            A.SupplementalFont supplementalFont35 = new A.SupplementalFont() { Script = "Lisu", Typeface = "Segoe UI" };
            A.SupplementalFont supplementalFont36 = new A.SupplementalFont() { Script = "Mymr", Typeface = "Myanmar Text" };
            A.SupplementalFont supplementalFont37 = new A.SupplementalFont() { Script = "Nkoo", Typeface = "Ebrima" };
            A.SupplementalFont supplementalFont38 = new A.SupplementalFont() { Script = "Olck", Typeface = "Nirmala UI" };
            A.SupplementalFont supplementalFont39 = new A.SupplementalFont() { Script = "Osma", Typeface = "Ebrima" };
            A.SupplementalFont supplementalFont40 = new A.SupplementalFont() { Script = "Phag", Typeface = "Phagspa" };
            A.SupplementalFont supplementalFont41 = new A.SupplementalFont() { Script = "Syrn", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont42 = new A.SupplementalFont() { Script = "Syrj", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont43 = new A.SupplementalFont() { Script = "Syre", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont44 = new A.SupplementalFont() { Script = "Sora", Typeface = "Nirmala UI" };
            A.SupplementalFont supplementalFont45 = new A.SupplementalFont() { Script = "Tale", Typeface = "Microsoft Tai Le" };
            A.SupplementalFont supplementalFont46 = new A.SupplementalFont() { Script = "Talu", Typeface = "Microsoft New Tai Lue" };
            A.SupplementalFont supplementalFont47 = new A.SupplementalFont() { Script = "Tfng", Typeface = "Ebrima" };

            majorFont1.Append(latinFont29);
            majorFont1.Append(eastAsianFont29);
            majorFont1.Append(complexScriptFont29);
            majorFont1.Append(supplementalFont1);
            majorFont1.Append(supplementalFont2);
            majorFont1.Append(supplementalFont3);
            majorFont1.Append(supplementalFont4);
            majorFont1.Append(supplementalFont5);
            majorFont1.Append(supplementalFont6);
            majorFont1.Append(supplementalFont7);
            majorFont1.Append(supplementalFont8);
            majorFont1.Append(supplementalFont9);
            majorFont1.Append(supplementalFont10);
            majorFont1.Append(supplementalFont11);
            majorFont1.Append(supplementalFont12);
            majorFont1.Append(supplementalFont13);
            majorFont1.Append(supplementalFont14);
            majorFont1.Append(supplementalFont15);
            majorFont1.Append(supplementalFont16);
            majorFont1.Append(supplementalFont17);
            majorFont1.Append(supplementalFont18);
            majorFont1.Append(supplementalFont19);
            majorFont1.Append(supplementalFont20);
            majorFont1.Append(supplementalFont21);
            majorFont1.Append(supplementalFont22);
            majorFont1.Append(supplementalFont23);
            majorFont1.Append(supplementalFont24);
            majorFont1.Append(supplementalFont25);
            majorFont1.Append(supplementalFont26);
            majorFont1.Append(supplementalFont27);
            majorFont1.Append(supplementalFont28);
            majorFont1.Append(supplementalFont29);
            majorFont1.Append(supplementalFont30);
            majorFont1.Append(supplementalFont31);
            majorFont1.Append(supplementalFont32);
            majorFont1.Append(supplementalFont33);
            majorFont1.Append(supplementalFont34);
            majorFont1.Append(supplementalFont35);
            majorFont1.Append(supplementalFont36);
            majorFont1.Append(supplementalFont37);
            majorFont1.Append(supplementalFont38);
            majorFont1.Append(supplementalFont39);
            majorFont1.Append(supplementalFont40);
            majorFont1.Append(supplementalFont41);
            majorFont1.Append(supplementalFont42);
            majorFont1.Append(supplementalFont43);
            majorFont1.Append(supplementalFont44);
            majorFont1.Append(supplementalFont45);
            majorFont1.Append(supplementalFont46);
            majorFont1.Append(supplementalFont47);

            A.MinorFont minorFont1 = new A.MinorFont();
            A.LatinFont latinFont30 = new A.LatinFont() { Typeface = "Calibri", Panose = "020F0502020204030204" };
            A.EastAsianFont eastAsianFont30 = new A.EastAsianFont() { Typeface = "" };
            A.ComplexScriptFont complexScriptFont30 = new A.ComplexScriptFont() { Typeface = "" };
            A.SupplementalFont supplementalFont48 = new A.SupplementalFont() { Script = "Jpan", Typeface = "游ゴシック" };
            A.SupplementalFont supplementalFont49 = new A.SupplementalFont() { Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont50 = new A.SupplementalFont() { Script = "Hans", Typeface = "等线" };
            A.SupplementalFont supplementalFont51 = new A.SupplementalFont() { Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont52 = new A.SupplementalFont() { Script = "Arab", Typeface = "Arial" };
            A.SupplementalFont supplementalFont53 = new A.SupplementalFont() { Script = "Hebr", Typeface = "Arial" };
            A.SupplementalFont supplementalFont54 = new A.SupplementalFont() { Script = "Thai", Typeface = "Cordia New" };
            A.SupplementalFont supplementalFont55 = new A.SupplementalFont() { Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont56 = new A.SupplementalFont() { Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont57 = new A.SupplementalFont() { Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont58 = new A.SupplementalFont() { Script = "Khmr", Typeface = "DaunPenh" };
            A.SupplementalFont supplementalFont59 = new A.SupplementalFont() { Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont60 = new A.SupplementalFont() { Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont61 = new A.SupplementalFont() { Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont62 = new A.SupplementalFont() { Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont63 = new A.SupplementalFont() { Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont64 = new A.SupplementalFont() { Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont65 = new A.SupplementalFont() { Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont66 = new A.SupplementalFont() { Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont67 = new A.SupplementalFont() { Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont68 = new A.SupplementalFont() { Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont69 = new A.SupplementalFont() { Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont70 = new A.SupplementalFont() { Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont71 = new A.SupplementalFont() { Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont72 = new A.SupplementalFont() { Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont73 = new A.SupplementalFont() { Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont74 = new A.SupplementalFont() { Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont75 = new A.SupplementalFont() { Script = "Viet", Typeface = "Arial" };
            A.SupplementalFont supplementalFont76 = new A.SupplementalFont() { Script = "Uigh", Typeface = "Microsoft Uighur" };
            A.SupplementalFont supplementalFont77 = new A.SupplementalFont() { Script = "Geor", Typeface = "Sylfaen" };
            A.SupplementalFont supplementalFont78 = new A.SupplementalFont() { Script = "Armn", Typeface = "Arial" };
            A.SupplementalFont supplementalFont79 = new A.SupplementalFont() { Script = "Bugi", Typeface = "Leelawadee UI" };
            A.SupplementalFont supplementalFont80 = new A.SupplementalFont() { Script = "Bopo", Typeface = "Microsoft JhengHei" };
            A.SupplementalFont supplementalFont81 = new A.SupplementalFont() { Script = "Java", Typeface = "Javanese Text" };
            A.SupplementalFont supplementalFont82 = new A.SupplementalFont() { Script = "Lisu", Typeface = "Segoe UI" };
            A.SupplementalFont supplementalFont83 = new A.SupplementalFont() { Script = "Mymr", Typeface = "Myanmar Text" };
            A.SupplementalFont supplementalFont84 = new A.SupplementalFont() { Script = "Nkoo", Typeface = "Ebrima" };
            A.SupplementalFont supplementalFont85 = new A.SupplementalFont() { Script = "Olck", Typeface = "Nirmala UI" };
            A.SupplementalFont supplementalFont86 = new A.SupplementalFont() { Script = "Osma", Typeface = "Ebrima" };
            A.SupplementalFont supplementalFont87 = new A.SupplementalFont() { Script = "Phag", Typeface = "Phagspa" };
            A.SupplementalFont supplementalFont88 = new A.SupplementalFont() { Script = "Syrn", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont89 = new A.SupplementalFont() { Script = "Syrj", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont90 = new A.SupplementalFont() { Script = "Syre", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont91 = new A.SupplementalFont() { Script = "Sora", Typeface = "Nirmala UI" };
            A.SupplementalFont supplementalFont92 = new A.SupplementalFont() { Script = "Tale", Typeface = "Microsoft Tai Le" };
            A.SupplementalFont supplementalFont93 = new A.SupplementalFont() { Script = "Talu", Typeface = "Microsoft New Tai Lue" };
            A.SupplementalFont supplementalFont94 = new A.SupplementalFont() { Script = "Tfng", Typeface = "Ebrima" };

            minorFont1.Append(latinFont30);
            minorFont1.Append(eastAsianFont30);
            minorFont1.Append(complexScriptFont30);
            minorFont1.Append(supplementalFont48);
            minorFont1.Append(supplementalFont49);
            minorFont1.Append(supplementalFont50);
            minorFont1.Append(supplementalFont51);
            minorFont1.Append(supplementalFont52);
            minorFont1.Append(supplementalFont53);
            minorFont1.Append(supplementalFont54);
            minorFont1.Append(supplementalFont55);
            minorFont1.Append(supplementalFont56);
            minorFont1.Append(supplementalFont57);
            minorFont1.Append(supplementalFont58);
            minorFont1.Append(supplementalFont59);
            minorFont1.Append(supplementalFont60);
            minorFont1.Append(supplementalFont61);
            minorFont1.Append(supplementalFont62);
            minorFont1.Append(supplementalFont63);
            minorFont1.Append(supplementalFont64);
            minorFont1.Append(supplementalFont65);
            minorFont1.Append(supplementalFont66);
            minorFont1.Append(supplementalFont67);
            minorFont1.Append(supplementalFont68);
            minorFont1.Append(supplementalFont69);
            minorFont1.Append(supplementalFont70);
            minorFont1.Append(supplementalFont71);
            minorFont1.Append(supplementalFont72);
            minorFont1.Append(supplementalFont73);
            minorFont1.Append(supplementalFont74);
            minorFont1.Append(supplementalFont75);
            minorFont1.Append(supplementalFont76);
            minorFont1.Append(supplementalFont77);
            minorFont1.Append(supplementalFont78);
            minorFont1.Append(supplementalFont79);
            minorFont1.Append(supplementalFont80);
            minorFont1.Append(supplementalFont81);
            minorFont1.Append(supplementalFont82);
            minorFont1.Append(supplementalFont83);
            minorFont1.Append(supplementalFont84);
            minorFont1.Append(supplementalFont85);
            minorFont1.Append(supplementalFont86);
            minorFont1.Append(supplementalFont87);
            minorFont1.Append(supplementalFont88);
            minorFont1.Append(supplementalFont89);
            minorFont1.Append(supplementalFont90);
            minorFont1.Append(supplementalFont91);
            minorFont1.Append(supplementalFont92);
            minorFont1.Append(supplementalFont93);
            minorFont1.Append(supplementalFont94);

            fontScheme1.Append(majorFont1);
            fontScheme1.Append(minorFont1);

            A.FormatScheme formatScheme1 = new A.FormatScheme() { Name = "Office" };

            A.FillStyleList fillStyleList1 = new A.FillStyleList();

            A.SolidFill solidFill29 = new A.SolidFill();
            A.SchemeColor schemeColor30 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill29.Append(schemeColor30);

            A.GradientFill gradientFill1 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList1 = new A.GradientStopList();

            A.GradientStop gradientStop1 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor31 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation1 = new A.LuminanceModulation() { Val = 110000 };
            A.SaturationModulation saturationModulation1 = new A.SaturationModulation() { Val = 105000 };
            A.Tint tint1 = new A.Tint() { Val = 67000 };

            schemeColor31.Append(luminanceModulation1);
            schemeColor31.Append(saturationModulation1);
            schemeColor31.Append(tint1);

            gradientStop1.Append(schemeColor31);

            A.GradientStop gradientStop2 = new A.GradientStop() { Position = 50000 };

            A.SchemeColor schemeColor32 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation2 = new A.LuminanceModulation() { Val = 105000 };
            A.SaturationModulation saturationModulation2 = new A.SaturationModulation() { Val = 103000 };
            A.Tint tint2 = new A.Tint() { Val = 73000 };

            schemeColor32.Append(luminanceModulation2);
            schemeColor32.Append(saturationModulation2);
            schemeColor32.Append(tint2);

            gradientStop2.Append(schemeColor32);

            A.GradientStop gradientStop3 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor33 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation3 = new A.LuminanceModulation() { Val = 105000 };
            A.SaturationModulation saturationModulation3 = new A.SaturationModulation() { Val = 109000 };
            A.Tint tint3 = new A.Tint() { Val = 81000 };

            schemeColor33.Append(luminanceModulation3);
            schemeColor33.Append(saturationModulation3);
            schemeColor33.Append(tint3);

            gradientStop3.Append(schemeColor33);

            gradientStopList1.Append(gradientStop1);
            gradientStopList1.Append(gradientStop2);
            gradientStopList1.Append(gradientStop3);
            A.LinearGradientFill linearGradientFill1 = new A.LinearGradientFill() { Angle = 5400000, Scaled = false };

            gradientFill1.Append(gradientStopList1);
            gradientFill1.Append(linearGradientFill1);

            A.GradientFill gradientFill2 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList2 = new A.GradientStopList();

            A.GradientStop gradientStop4 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor34 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.SaturationModulation saturationModulation4 = new A.SaturationModulation() { Val = 103000 };
            A.LuminanceModulation luminanceModulation4 = new A.LuminanceModulation() { Val = 102000 };
            A.Tint tint4 = new A.Tint() { Val = 94000 };

            schemeColor34.Append(saturationModulation4);
            schemeColor34.Append(luminanceModulation4);
            schemeColor34.Append(tint4);

            gradientStop4.Append(schemeColor34);

            A.GradientStop gradientStop5 = new A.GradientStop() { Position = 50000 };

            A.SchemeColor schemeColor35 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.SaturationModulation saturationModulation5 = new A.SaturationModulation() { Val = 110000 };
            A.LuminanceModulation luminanceModulation5 = new A.LuminanceModulation() { Val = 100000 };
            A.Shade shade1 = new A.Shade() { Val = 100000 };

            schemeColor35.Append(saturationModulation5);
            schemeColor35.Append(luminanceModulation5);
            schemeColor35.Append(shade1);

            gradientStop5.Append(schemeColor35);

            A.GradientStop gradientStop6 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor36 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation6 = new A.LuminanceModulation() { Val = 99000 };
            A.SaturationModulation saturationModulation6 = new A.SaturationModulation() { Val = 120000 };
            A.Shade shade2 = new A.Shade() { Val = 78000 };

            schemeColor36.Append(luminanceModulation6);
            schemeColor36.Append(saturationModulation6);
            schemeColor36.Append(shade2);

            gradientStop6.Append(schemeColor36);

            gradientStopList2.Append(gradientStop4);
            gradientStopList2.Append(gradientStop5);
            gradientStopList2.Append(gradientStop6);
            A.LinearGradientFill linearGradientFill2 = new A.LinearGradientFill() { Angle = 5400000, Scaled = false };

            gradientFill2.Append(gradientStopList2);
            gradientFill2.Append(linearGradientFill2);

            fillStyleList1.Append(solidFill29);
            fillStyleList1.Append(gradientFill1);
            fillStyleList1.Append(gradientFill2);

            A.LineStyleList lineStyleList1 = new A.LineStyleList();

            A.Outline outline1 = new A.Outline() { Width = 6350, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill30 = new A.SolidFill();
            A.SchemeColor schemeColor37 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill30.Append(schemeColor37);
            A.PresetDash presetDash1 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };
            A.Miter miter1 = new A.Miter() { Limit = 800000 };

            outline1.Append(solidFill30);
            outline1.Append(presetDash1);
            outline1.Append(miter1);

            A.Outline outline2 = new A.Outline() { Width = 12700, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill31 = new A.SolidFill();
            A.SchemeColor schemeColor38 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill31.Append(schemeColor38);
            A.PresetDash presetDash2 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };
            A.Miter miter2 = new A.Miter() { Limit = 800000 };

            outline2.Append(solidFill31);
            outline2.Append(presetDash2);
            outline2.Append(miter2);

            A.Outline outline3 = new A.Outline() { Width = 19050, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill32 = new A.SolidFill();
            A.SchemeColor schemeColor39 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill32.Append(schemeColor39);
            A.PresetDash presetDash3 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };
            A.Miter miter3 = new A.Miter() { Limit = 800000 };

            outline3.Append(solidFill32);
            outline3.Append(presetDash3);
            outline3.Append(miter3);

            lineStyleList1.Append(outline1);
            lineStyleList1.Append(outline2);
            lineStyleList1.Append(outline3);

            A.EffectStyleList effectStyleList1 = new A.EffectStyleList();

            A.EffectStyle effectStyle1 = new A.EffectStyle();
            A.EffectList effectList1 = new A.EffectList();

            effectStyle1.Append(effectList1);

            A.EffectStyle effectStyle2 = new A.EffectStyle();
            A.EffectList effectList2 = new A.EffectList();

            effectStyle2.Append(effectList2);

            A.EffectStyle effectStyle3 = new A.EffectStyle();

            A.EffectList effectList3 = new A.EffectList();

            A.OuterShadow outerShadow1 = new A.OuterShadow() { BlurRadius = 57150L, Distance = 19050L, Direction = 5400000, Alignment = A.RectangleAlignmentValues.Center, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex11 = new A.RgbColorModelHex() { Val = "000000" };
            A.Alpha alpha1 = new A.Alpha() { Val = 63000 };

            rgbColorModelHex11.Append(alpha1);

            outerShadow1.Append(rgbColorModelHex11);

            effectList3.Append(outerShadow1);

            effectStyle3.Append(effectList3);

            effectStyleList1.Append(effectStyle1);
            effectStyleList1.Append(effectStyle2);
            effectStyleList1.Append(effectStyle3);

            A.BackgroundFillStyleList backgroundFillStyleList1 = new A.BackgroundFillStyleList();

            A.SolidFill solidFill33 = new A.SolidFill();
            A.SchemeColor schemeColor40 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill33.Append(schemeColor40);

            A.SolidFill solidFill34 = new A.SolidFill();

            A.SchemeColor schemeColor41 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint5 = new A.Tint() { Val = 95000 };
            A.SaturationModulation saturationModulation7 = new A.SaturationModulation() { Val = 170000 };

            schemeColor41.Append(tint5);
            schemeColor41.Append(saturationModulation7);

            solidFill34.Append(schemeColor41);

            A.GradientFill gradientFill3 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList3 = new A.GradientStopList();

            A.GradientStop gradientStop7 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor42 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint6 = new A.Tint() { Val = 93000 };
            A.SaturationModulation saturationModulation8 = new A.SaturationModulation() { Val = 150000 };
            A.Shade shade3 = new A.Shade() { Val = 98000 };
            A.LuminanceModulation luminanceModulation7 = new A.LuminanceModulation() { Val = 102000 };

            schemeColor42.Append(tint6);
            schemeColor42.Append(saturationModulation8);
            schemeColor42.Append(shade3);
            schemeColor42.Append(luminanceModulation7);

            gradientStop7.Append(schemeColor42);

            A.GradientStop gradientStop8 = new A.GradientStop() { Position = 50000 };

            A.SchemeColor schemeColor43 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint7 = new A.Tint() { Val = 98000 };
            A.SaturationModulation saturationModulation9 = new A.SaturationModulation() { Val = 130000 };
            A.Shade shade4 = new A.Shade() { Val = 90000 };
            A.LuminanceModulation luminanceModulation8 = new A.LuminanceModulation() { Val = 103000 };

            schemeColor43.Append(tint7);
            schemeColor43.Append(saturationModulation9);
            schemeColor43.Append(shade4);
            schemeColor43.Append(luminanceModulation8);

            gradientStop8.Append(schemeColor43);

            A.GradientStop gradientStop9 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor44 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade5 = new A.Shade() { Val = 63000 };
            A.SaturationModulation saturationModulation10 = new A.SaturationModulation() { Val = 120000 };

            schemeColor44.Append(shade5);
            schemeColor44.Append(saturationModulation10);

            gradientStop9.Append(schemeColor44);

            gradientStopList3.Append(gradientStop7);
            gradientStopList3.Append(gradientStop8);
            gradientStopList3.Append(gradientStop9);
            A.LinearGradientFill linearGradientFill3 = new A.LinearGradientFill() { Angle = 5400000, Scaled = false };

            gradientFill3.Append(gradientStopList3);
            gradientFill3.Append(linearGradientFill3);

            backgroundFillStyleList1.Append(solidFill33);
            backgroundFillStyleList1.Append(solidFill34);
            backgroundFillStyleList1.Append(gradientFill3);

            formatScheme1.Append(fillStyleList1);
            formatScheme1.Append(lineStyleList1);
            formatScheme1.Append(effectStyleList1);
            formatScheme1.Append(backgroundFillStyleList1);

            themeElements1.Append(colorScheme1);
            themeElements1.Append(fontScheme1);
            themeElements1.Append(formatScheme1);
            A.ObjectDefaults objectDefaults1 = new A.ObjectDefaults();
            A.ExtraColorSchemeList extraColorSchemeList1 = new A.ExtraColorSchemeList();

            A.OfficeStyleSheetExtensionList officeStyleSheetExtensionList1 = new A.OfficeStyleSheetExtensionList();

            A.OfficeStyleSheetExtension officeStyleSheetExtension1 = new A.OfficeStyleSheetExtension() { Uri = "{05A4C25C-085E-4340-85A3-A5531E510DB2}" };

            Thm15.ThemeFamily themeFamily1 = new Thm15.ThemeFamily() { Name = "Office Theme", Id = "{62F939B6-93AF-4DB8-9C6B-D6C7DFDC589F}", Vid = "{4A3C46E8-61CC-4603-A589-7422A47A8E4A}" };
            themeFamily1.AddNamespaceDeclaration("thm15", "http://schemas.microsoft.com/office/thememl/2012/main");

            officeStyleSheetExtension1.Append(themeFamily1);

            officeStyleSheetExtensionList1.Append(officeStyleSheetExtension1);

            theme1.Append(themeElements1);
            theme1.Append(objectDefaults1);
            theme1.Append(extraColorSchemeList1);
            theme1.Append(officeStyleSheetExtensionList1);

            themePart1.Theme = theme1;
        }

        // Generates content of imagePart3.
        private void GenerateImagePart3Content(ImagePart imagePart3)
        {
            System.IO.Stream data = GetBinaryDataStream(_image3);
            imagePart3.FeedData(data);
            data.Close();
        }

        // Generates content of tableStylesPart1.
        private void GenerateTableStylesPart1Content(TableStylesPart tableStylesPart1)
        {
            A.TableStyleList tableStyleList1 = new A.TableStyleList() { Default = "{5C22544A-7EE6-4342-B048-85BDC9FD1C3A}" };
            tableStyleList1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            tableStylesPart1.TableStyleList = tableStyleList1;
        }

        // Generates content of viewPropertiesPart1.
        private void GenerateViewPropertiesPart1Content(ViewPropertiesPart viewPropertiesPart1)
        {
            ViewProperties viewProperties1 = new ViewProperties();
            viewProperties1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            viewProperties1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            viewProperties1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            NormalViewProperties normalViewProperties1 = new NormalViewProperties();
            RestoredLeft restoredLeft1 = new RestoredLeft() { Size = 15620 };
            RestoredTop restoredTop1 = new RestoredTop() { Size = 94660 };

            normalViewProperties1.Append(restoredLeft1);
            normalViewProperties1.Append(restoredTop1);

            SlideViewProperties slideViewProperties1 = new SlideViewProperties();

            CommonSlideViewProperties commonSlideViewProperties1 = new CommonSlideViewProperties() { SnapToGrid = false };

            CommonViewProperties commonViewProperties1 = new CommonViewProperties() { VariableScale = true };

            ScaleFactor scaleFactor1 = new ScaleFactor();
            A.ScaleX scaleX1 = new A.ScaleX() { Numerator = 98, Denominator = 100 };
            A.ScaleY scaleY1 = new A.ScaleY() { Numerator = 98, Denominator = 100 };

            scaleFactor1.Append(scaleX1);
            scaleFactor1.Append(scaleY1);
            Origin origin1 = new Origin() { X = 72L, Y = 444L };

            commonViewProperties1.Append(scaleFactor1);
            commonViewProperties1.Append(origin1);
            GuideList guideList1 = new GuideList();

            commonSlideViewProperties1.Append(commonViewProperties1);
            commonSlideViewProperties1.Append(guideList1);

            slideViewProperties1.Append(commonSlideViewProperties1);

            NotesTextViewProperties notesTextViewProperties1 = new NotesTextViewProperties();

            CommonViewProperties commonViewProperties2 = new CommonViewProperties();

            ScaleFactor scaleFactor2 = new ScaleFactor();
            A.ScaleX scaleX2 = new A.ScaleX() { Numerator = 1, Denominator = 1 };
            A.ScaleY scaleY2 = new A.ScaleY() { Numerator = 1, Denominator = 1 };

            scaleFactor2.Append(scaleX2);
            scaleFactor2.Append(scaleY2);
            Origin origin2 = new Origin() { X = 0L, Y = 0L };

            commonViewProperties2.Append(scaleFactor2);
            commonViewProperties2.Append(origin2);

            notesTextViewProperties1.Append(commonViewProperties2);
            GridSpacing gridSpacing1 = new GridSpacing() { Cx = 76200L, Cy = 76200L };

            viewProperties1.Append(normalViewProperties1);
            viewProperties1.Append(slideViewProperties1);
            viewProperties1.Append(notesTextViewProperties1);
            viewProperties1.Append(gridSpacing1);

            viewPropertiesPart1.ViewProperties = viewProperties1;
        }

        // Generates content of extendedFilePropertiesPart1.
        private void GenerateExtendedFilePropertiesPart1Content(ExtendedFilePropertiesPart extendedFilePropertiesPart1)
        {
            Ap.Properties properties1 = new Ap.Properties();
            properties1.AddNamespaceDeclaration("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");
            Ap.TotalTime totalTime1 = new Ap.TotalTime();
            totalTime1.Text = "5";
            Ap.Words words1 = new Ap.Words();
            words1.Text = "2";
            Ap.Application application1 = new Ap.Application();
            application1.Text = "Microsoft Office PowerPoint";
            Ap.PresentationFormat presentationFormat1 = new Ap.PresentationFormat();
            presentationFormat1.Text = "Widescreen";
            Ap.Paragraphs paragraphs1 = new Ap.Paragraphs();
            paragraphs1.Text = "2";
            Ap.Slides slides1 = new Ap.Slides();
            slides1.Text = "1";
            Ap.Notes notes1 = new Ap.Notes();
            notes1.Text = "0";
            Ap.HiddenSlides hiddenSlides1 = new Ap.HiddenSlides();
            hiddenSlides1.Text = "0";
            Ap.MultimediaClips multimediaClips1 = new Ap.MultimediaClips();
            multimediaClips1.Text = "0";
            Ap.ScaleCrop scaleCrop1 = new Ap.ScaleCrop();
            scaleCrop1.Text = "false";

            Ap.HeadingPairs headingPairs1 = new Ap.HeadingPairs();

            Vt.VTVector vTVector1 = new Vt.VTVector() { BaseType = Vt.VectorBaseValues.Variant, Size = (UInt32Value)6U };

            Vt.Variant variant1 = new Vt.Variant();
            Vt.VTLPSTR vTLPSTR1 = new Vt.VTLPSTR();
            vTLPSTR1.Text = "Fonts Used";

            variant1.Append(vTLPSTR1);

            Vt.Variant variant2 = new Vt.Variant();
            Vt.VTInt32 vTInt321 = new Vt.VTInt32();
            vTInt321.Text = "3";

            variant2.Append(vTInt321);

            Vt.Variant variant3 = new Vt.Variant();
            Vt.VTLPSTR vTLPSTR2 = new Vt.VTLPSTR();
            vTLPSTR2.Text = "Theme";

            variant3.Append(vTLPSTR2);

            Vt.Variant variant4 = new Vt.Variant();
            Vt.VTInt32 vTInt322 = new Vt.VTInt32();
            vTInt322.Text = "1";

            variant4.Append(vTInt322);

            Vt.Variant variant5 = new Vt.Variant();
            Vt.VTLPSTR vTLPSTR3 = new Vt.VTLPSTR();
            vTLPSTR3.Text = "Slide Titles";

            variant5.Append(vTLPSTR3);

            Vt.Variant variant6 = new Vt.Variant();
            Vt.VTInt32 vTInt323 = new Vt.VTInt32();
            vTInt323.Text = "1";

            variant6.Append(vTInt323);

            vTVector1.Append(variant1);
            vTVector1.Append(variant2);
            vTVector1.Append(variant3);
            vTVector1.Append(variant4);
            vTVector1.Append(variant5);
            vTVector1.Append(variant6);

            headingPairs1.Append(vTVector1);

            Ap.TitlesOfParts titlesOfParts1 = new Ap.TitlesOfParts();

            Vt.VTVector vTVector2 = new Vt.VTVector() { BaseType = Vt.VectorBaseValues.Lpstr, Size = (UInt32Value)5U };
            Vt.VTLPSTR vTLPSTR4 = new Vt.VTLPSTR();
            vTLPSTR4.Text = "Arial";
            Vt.VTLPSTR vTLPSTR5 = new Vt.VTLPSTR();
            vTLPSTR5.Text = "Calibri";
            Vt.VTLPSTR vTLPSTR6 = new Vt.VTLPSTR();
            vTLPSTR6.Text = "Calibri Light";
            Vt.VTLPSTR vTLPSTR7 = new Vt.VTLPSTR();
            vTLPSTR7.Text = "Office Theme";
            Vt.VTLPSTR vTLPSTR8 = new Vt.VTLPSTR();
            vTLPSTR8.Text = "Title";

            vTVector2.Append(vTLPSTR4);
            vTVector2.Append(vTLPSTR5);
            vTVector2.Append(vTLPSTR6);
            vTVector2.Append(vTLPSTR7);
            vTVector2.Append(vTLPSTR8);

            titlesOfParts1.Append(vTVector2);
            Ap.LinksUpToDate linksUpToDate1 = new Ap.LinksUpToDate();
            linksUpToDate1.Text = "false";
            Ap.SharedDocument sharedDocument1 = new Ap.SharedDocument();
            sharedDocument1.Text = "false";
            Ap.HyperlinksChanged hyperlinksChanged1 = new Ap.HyperlinksChanged();
            hyperlinksChanged1.Text = "false";
            Ap.ApplicationVersion applicationVersion1 = new Ap.ApplicationVersion();
            applicationVersion1.Text = "16.0000";

            properties1.Append(totalTime1);
            properties1.Append(words1);
            properties1.Append(application1);
            properties1.Append(presentationFormat1);
            properties1.Append(paragraphs1);
            properties1.Append(slides1);
            properties1.Append(notes1);
            properties1.Append(hiddenSlides1);
            properties1.Append(multimediaClips1);
            properties1.Append(scaleCrop1);
            properties1.Append(headingPairs1);
            properties1.Append(titlesOfParts1);
            properties1.Append(linksUpToDate1);
            properties1.Append(sharedDocument1);
            properties1.Append(hyperlinksChanged1);
            properties1.Append(applicationVersion1);

            extendedFilePropertiesPart1.Properties = properties1;
        }

        private void SetPackageProperties(OpenXmlPackage document)
        {
            document.PackageProperties.Creator = "Dave Stamper";
            document.PackageProperties.Title = "Title";
            document.PackageProperties.Revision = "4";
            document.PackageProperties.Created = System.Xml.XmlConvert.ToDateTime("2019-03-13T17:50:10Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.Modified = System.Xml.XmlConvert.ToDateTime("2019-03-13T20:57:55Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.LastModifiedBy = "Dave Stamper";
        }

        #region Binary Data
        private string thumbnailPart1Data = "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";
        

        private System.IO.Stream GetBinaryDataStream(string base64String)
        {
            return new System.IO.MemoryStream(System.Convert.FromBase64String(base64String));
        }

        #endregion

    }
}
