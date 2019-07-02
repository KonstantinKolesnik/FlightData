using FlightData.Core;
using System;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace FlightData
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            var picker = new FileOpenPicker
            {
                ViewMode = PickerViewMode.Thumbnail,
                SuggestedStartLocation = PickerLocationId.DocumentsLibrary
            };
            picker.FileTypeFilter.Add(".txt");
            picker.FileTypeFilter.Add(".dat");

            var file = await picker.PickSingleFileAsync();
            if (file != null)
            {
                //var data = await FileIO.ReadTextAsync(file);

                var buffer = await FileIO.ReadBufferAsync(file);
                using (var dataReader = DataReader.FromBuffer(buffer))
                {
                    var data = new byte[buffer.Length];
                    dataReader.ReadBytes(data);

                    var fr = new FlightRecord(data);

                }
            }
        }
    }
}
