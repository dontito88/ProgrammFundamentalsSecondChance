namespace _4.SyntaxMoreEx04PhotoGallery
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PhotoGallery
    {
        public static void Main()
        {
            var fileNumber = int.Parse(Console.ReadLine());
            var date = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var size = double.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            string orientation = string.Empty;

            Console.WriteLine($"Name: DSC_{fileNumber.ToString("0000")}.jpg");
            Console.WriteLine($"Date Taken: {date.ToString("00")}/{month.ToString("00")}/{year} {hour.ToString("00")}:{minutes.ToString("00")}");
            if (size <= 1024)
            {
                Console.WriteLine($"Size: {size}B");
            }
            else if (size > 1024 && size <= 1024000)
            {
                Console.WriteLine($"Size: {size / 1000}KB");
            }
            else if (size > 1024000)
            {
                Console.WriteLine($"Size: {(size / 1000000).ToString("0.0")}MB");
            }
            if (width > height)
            {
                orientation = "landscape";
            }
            else if (width < height)
            {
                orientation = "portrait";
            }
            else if (width == height)
            {
                orientation = "square";
            }
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}
