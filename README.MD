# Power Point Image Search

## Description
A WinForms based image aid, designed to search the internet and pull relevant images to be used in PowerPoint presentations.

## Use
Enter a valid title and body text of your slide. Clicking lookup with search the web for results related to the title, and bold keywords in the body.
Selected images can be either manually saved, or export as a pptx. Currently the aspect ratio of the generated images is messed up in the XML.

### API
The API I used for the imsage searching is [Unsplash](https://unsplash.com/)


## Build instructions
Clone and build. This project is targeting .NET Framework Version 4.6.1

#Important note:
My API access key is not provided inside this GitHub repo - please see the attached files you received along with my application.

It needs to be placed in the APIKEY value in App.config if you are building it yourself, or place the provided WinFormViewer.exe.config inside the bin folder alongside the executable.
