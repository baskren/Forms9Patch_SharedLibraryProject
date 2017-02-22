# Forms9Patch_SharedLibraryProject
Demonstration of using Forms9Patch in Shared Library iOS and Android Projects

This project takes the [Forms9PatchDemo project](https://github.com/baskren/Forms9PatchDemo) and modifies it to work 
in a Share Library project configuration.  Note the following changes were required:

1. Be sure the App Name is the same as the Forms9Patch License Key.  See "How do I configure my license key?" at [Forms9Patch.com](http://Forms9Patch.com).
2. Xamarin Studio did not assign Resource IDs to images and font files when I added as Embedded Resources to my shared project.  So, I had to do this manually.  You can do this by right clicking on the file and selecting `Properties`.  If you have a lot of files, you might find it easier to modify the `.projitems` file for your shared project.
3. Some of Forms9Patch demo's XAML uses the app's local namespace to extend the `Source` attribute of the `Forms9Patch.Image` tag.  In PCL projects, this is done via `xmlns:local="clr-namespace:SharedApp;assembly=SharedApp"`.  In Shared Library Projects, you'll want to drop the assembly parameter: `xmlns:local="clr-namespace:SharedApp;"`.
