using System;
using Windows.Media.Capture;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace taa_demo_net
{
    public sealed partial class MainPage : Page
    {
        private async void OnTakePhotoClick(object sender, RoutedEventArgs e)
        {
            // Capture a new photo or video from the device.
            var cameraCapture = new CameraCaptureUI();
            media = await cameraCapture.CaptureFileAsync(CameraCaptureUIMode.Photo);
        }
    }
}
