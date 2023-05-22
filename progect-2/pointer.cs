// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter the point (x,y)");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Point p1 = new Point( x,  y);
            p1.Print(x, y);
            p1.Quadrant(x, y);
            p1.Move(x, y);
 class Point
    {
        private int x;
        private int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Move(int x,int y)
        {
            x-=5;
            y += 5;
            Console.WriteLine($"the point in ({x}, {y})");
        }
        public void Print(int x, int y)
        {
            Console.WriteLine($"the point in ({x}, {y})");
        }
        public void Quadrant(int x, int y)
        {
            if ((x >= 0) && (y >= 0))
                Console.WriteLine("first suqer");
            else if((x>=0)&&(y<=0))
                Console.WriteLine("forth suqer");
            else if((x<=0)&&(y<=0))
                Console.WriteLine("therd suqer");
            if ((y >= 0) && (x <= 0))
                Console.WriteLine("secend suqer");
        }
    }