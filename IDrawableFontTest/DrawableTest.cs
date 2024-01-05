namespace IDrawableFontTest
{
    internal class DrawableTest : IDrawable
    {
        private MainPage _page;

        public DrawableTest(MainPage page)
        {
            _page = page;
        }

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            string fontFamily;
            string text = "Test Text";
            float fontSize;

            RectF rect = dirtyRect.Inflate(-0.1f * dirtyRect.Width, -0.1f * dirtyRect.Height);

            if (_page.Extent is not null)
            {
                if (_page.Extent.Value.X > rect.X && _page.Extent.Value.Y > rect.Y) 
                {
                    rect = new(rect.X, rect.Y, (float)_page.Extent.Value.X - rect.X, (float)_page.Extent.Value.Y - rect.Y);
                    canvas.FillColor = Colors.Red;
                    canvas.FillCircle(rect.Right, rect.Bottom, dirtyRect.Width / 120);
                    canvas.FillColor = null;
                }
            }

            canvas.StrokeColor = Colors.Black;
            canvas.DrawRectangle(rect);

            Microsoft.Maui.Graphics.Font font;
            SizeF size;

            if (OperatingSystem.IsAndroid())
                fontFamily = "Cinzel-Regular.ttf";
            else
                fontFamily = "Cinzel";

            font = new(fontFamily);
            //font = new("Arial");  // To test default.

            // Get the size to display the text at 120 points.
            size = canvas.GetStringSize(text, font, 120f, HorizontalAlignment.Center, VerticalAlignment.Center);

            // Scale the font for use.
            fontSize = 120f * Math.Min(rect.Width / size.Width, rect.Height / size.Height);
            canvas.FontSize = fontSize;

            size = canvas.GetStringSize(text, font, fontSize, HorizontalAlignment.Center, VerticalAlignment.Center);

            RectF textRect = new(rect.Left + (rect.Width - size.Width) / 2,
                                 rect.Top + (rect.Height - size.Height) / 2,
                                 size.Width, size.Height);

            // To keep the font from overflowing (because MeasureText isn't exact, it seems).
            canvas.FontSize = fontSize * 0.9921f;

            canvas.StrokeColor = Colors.Blue;
            canvas.DrawRectangle(textRect);

            // Set the font and draw the string.
            canvas.Font = font;
            canvas.FontColor = Colors.Black;
            canvas.DrawString(text, textRect, HorizontalAlignment.Center, VerticalAlignment.Center, TextFlow.OverflowBounds);
        }
    }
}
