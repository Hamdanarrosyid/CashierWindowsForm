using System;
using System.Drawing;
using System.IO;
using ZXing;

public class BarcodeGenerator
{
    public string GenerateBarcode(int id)
    {
        // Create a BarcodeWriter instance
        BarcodeWriter barcodeWriter = new BarcodeWriter();
        barcodeWriter.Format = BarcodeFormat.QR_CODE;

        // Set encoding options (if needed)
        barcodeWriter.Options = new ZXing.Common.EncodingOptions
        {
            Width = 300,    // Set the width of the barcode image
            Height = 300    // Set the height of the barcode image
        };

        // Generate the barcode
        var barcodeBitmap = barcodeWriter.Write(id.ToString());

        // Convert the barcode image to a Base64-encoded string
        string base64String = ConvertImageToBase64(barcodeBitmap);

        return base64String;
    }

    private string ConvertImageToBase64(Bitmap image)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            // Save the image to the MemoryStream in PNG format
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

            // Convert the image to a byte array
            byte[] imageBytes = ms.ToArray();

            // Convert the byte array to a Base64-encoded string
            string base64String = Convert.ToBase64String(imageBytes);

            return base64String;
        }
    }

}
