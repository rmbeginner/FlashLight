# FlashLight 

Mobile App(Xamarin Forms) (Project Template)

Xamarin.
This is not working on Visual Studio 2022 if you put in AssemblyInfo.cs so I used the one in AndroidManifest.xml in API page

C#
[assembly: UsesFeature("android.hardware.camera", Required = false)]
[assembly: UsesFeature("android.hardware.camera.autofocus", Required = false)]

AndroidManifest.xml
<uses-permission android:name="android.permission.FLASHLIGHT" />
<uses-permission android:name="android.permission.CAMERA" />

