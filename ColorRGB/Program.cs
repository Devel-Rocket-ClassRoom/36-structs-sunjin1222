using System;
using System.Drawing;

// README.md를 읽고 코드를 작성하세요.
ColorRGB color1 =new ColorRGB(255,0,0);
Console.WriteLine($"빨강-R:{color1.R}, G:{color1.G} B:{color1.B} ->밝기{color1.GetBrightness()}");
ColorRGB color2 = new ColorRGB(255, 255, 255);
Console.WriteLine($"흰색-R:{color2.R}, G:{color2.G} B:{color2.B} ->밝기{color2.GetBrightness()}");
ColorRGB color3 = new ColorRGB(100, 150, 200);
Console.WriteLine($"커스텀-R:{color3.R}, G:{color3.G} B:{color3.B} ->밝기{color3.GetBrightness()}");
