using System;
using System.Drawing;
namespace ClanceysLib
{
	public static class Extensions
	{
		#region Points
		public static PointF Subtract(this PointF orgPoint, PointF point)
        {
			var x = orgPoint.X - point.X;
			var y = orgPoint.Y - point.Y;
			return new PointF(x,y);
        }
		public static PointF Add(this PointF orgPoint, PointF point)
        {
			var x = orgPoint.X + point.X;
			var y = orgPoint.Y + point.Y;
			return new PointF(x,y);
        }
		
		public static PointF Add(this PointF orgPoint, Size size)
        {
			var x = orgPoint.X + size.Width;
			var y = orgPoint.Y + size.Height;
			return new PointF(x,y);
        }
		
		public static PointF Add(this PointF orgPoint, SizeF size)
        {
			var x = orgPoint.X + size.Width;
			var y = orgPoint.Y + size.Height;
			return new PointF(x,y);
        }
		
		public static Point Add(this Point orgPoint, Point point)
        {
			var x = orgPoint.X + point.X;
			var y = orgPoint.Y + point.Y;
			return new Point(x,y);
        }
		public static Point Subtract(this Point orgPoint, Point point)
        {
			var x = orgPoint.X - point.X;
			var y = orgPoint.Y - point.Y;
			return new Point(x,y);
        }
		
		public static Point Subtract(this Point orgPoint, PointF point)
        {
			var pointF = Point.Round(point);
			var x = orgPoint.X - pointF.X;
			var y = orgPoint.Y - pointF.Y;
			return new Point(x,y);
        }
		#endregion
		
		#region Sizes
		public static SizeF Subtract(this SizeF orgSize, PointF point)
        {
			var x = orgSize.Width - point.X;
			var y = orgSize.Height - point.Y;
			return new SizeF(x,y);
        }
		public static SizeF Add(this SizeF orgSize, PointF point)
        {
			var x = orgSize.Width + point.X;
			var y = orgSize.Height + point.Y;
			return new SizeF(x,y);
        }
		
		public static SizeF Add(this SizeF orgSize, Size size)
        {
			var x = orgSize.Width + size.Width;
			var y = orgSize.Height + size.Height;
			return new SizeF(x,y);
        }
		
		public static SizeF Add(this SizeF orgSize, SizeF size)
        {
			var x = orgSize.Width + size.Width;
			var y = orgSize.Height + size.Height;
			return new SizeF(x,y);
        }
		
		public static Size Add(this Size orgSize, Point point)
        {
			var x = orgSize.Width + point.X;
			var y = orgSize.Height + point.Y;
			return new Size(x,y);
        }
		public static Size Subtract(this Size orgSize, Point point)
        {
			var x = orgSize.Width - point.X;
			var y = orgSize.Height - point.Y;
			return new Size(x,y);
        }
		
		public static SizeF Subtract(this SizeF orgSize, SizeF size)
        {
			var x = orgSize.Width - size.Width;
			var y = orgSize.Height - size.Height;
			return new SizeF(x,y);
        }
		
		public static Size Subtract(this Size orgSize, SizeF size)
        {
			var sizeF = Size.Round(size);
			var x = orgSize.Width - sizeF.Width;
			var y = orgSize.Height - sizeF.Height;
			return new Size(x,y);
        }
		#endregion
		
		#region Rectangles
		public static RectangleF SetLocation( this RectangleF orgRect, PointF point)
		{
			orgRect.Location = point;
			return orgRect;
		}
		
		public static RectangleF SetSize( this RectangleF orgRect, SizeF size)
		{
			orgRect.Size = size;
			return orgRect;
		}
		
		public static RectangleF Add( this RectangleF orgRect, SizeF size)
		{
			orgRect.Size = 	orgRect.Size.Add(size);
			return orgRect;
		}
		public static RectangleF Add ( this RectangleF orgRect, PointF point)
		{
			orgRect.Location = orgRect.Location.Add(point);
			return orgRect;
		}
		
		public static RectangleF Add (this RectangleF orgRect, PointF point, SizeF size)
		{
			orgRect.Location = orgRect.Location.Add(point);
			orgRect.Size = orgRect.Size.Add(size);
			return orgRect;
		}
		
		public static  RectangleF Subtract( this RectangleF orgRect, SizeF size)
		{
			orgRect.Size =  orgRect.Size.Subtract(size);
			return orgRect;
		}
		
		public static  RectangleF Subtract( this RectangleF orgRect, PointF point)
		{
			orgRect.Location = 	orgRect.Location.Subtract(point);
			return orgRect;
		}
		
		public static RectangleF Subtract (this RectangleF orgRect, PointF point, SizeF size)
		{
			orgRect.Location = orgRect.Location.Subtract(point);
			orgRect.Size = orgRect.Size.Subtract(size);
			return orgRect;
		}
		#endregion
	}
}
