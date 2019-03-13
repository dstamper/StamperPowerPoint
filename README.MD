# Power Point Image Search

## Description
A WinForms based image aid, designed to search the internet and pull relevant images to be used in PowerPoint presentations.

### API
The API I used for the imsage searching is [Unsplash](https://unsplash.com/)


## Build instructions
Clone and run Update-Package -reinstall inside the Nuget package manager console.

This project is targeting .NET Framework Version 4.6.1

# Important note: Will fail to compile if no key is provided
My API access key is not provided inside this GitHub repo - please see the attached files you received along with my application via email.

It needs to be placed in the APIKEY value in App.config if you are building it yourself, or place the provided WinFormViewer.exe.config inside the bin folder alongside the executable.

It should look like the following:

    <appSettings>  
      <add key="APIKEY" value="Client-ID xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" />
    </appSettings>
