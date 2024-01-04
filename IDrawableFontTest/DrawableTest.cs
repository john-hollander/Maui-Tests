namespace IDrawableFontTest
{
    internal class DrawableTest : IDrawable
    {
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            string fontFamily;
            string text = "Test Text";
            float fontSize;

            RectF rect = dirtyRect.Inflate(-0.1f * dirtyRect.Width, -0.1f * dirtyRect.Height);

            canvas.StrokeColor = Colors.Black;
            canvas.DrawRectangle(rect);

            Microsoft.Maui.Graphics.Font font;
            SizeF size;

            // Get the size to display the text at 120 points.

            if (OperatingSystem.IsAndroid())
                fontFamily = "Cinzel-Regular.ttf";
            else
                fontFamily = "Cinzel";

            font = new(fontFamily);
            size = canvas.GetStringSize(text, font, 120f, HorizontalAlignment.Center, VerticalAlignment.Center);

            // Scale the font for use.
            fontSize = 120f * Math.Min(rect.Width / size.Width, rect.Height / size.Height);
            canvas.FontSize = fontSize;

            size = canvas.GetStringSize(text, font, fontSize, HorizontalAlignment.Center, VerticalAlignment.Center);

            RectF textRect = new(rect.Left + (rect.Width - size.Width) / 2,
                                 rect.Top + (rect.Height - size.Height) / 2,
                                 size.Width, size.Height);

            canvas.StrokeColor = Colors.Blue;
            canvas.DrawRectangle(textRect);

            // Set the font and draw the string.
            canvas.Font = font;
            canvas.FontColor = Colors.Black;
            canvas.DrawString(text, textRect, HorizontalAlignment.Center, VerticalAlignment.Center, TextFlow.OverflowBounds);
        }
    }
}
