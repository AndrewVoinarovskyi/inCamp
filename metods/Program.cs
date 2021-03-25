using System;

namespace metods
{
    class Program
    {
        struct Point
        {
            public int x;
            public int y;
        
            public override string ToString()
            {
                return $"x: {x}, y: {y}";
            }
        }
        class Rect
        {
            public Point upperLeft;
            public int width;
            public int height;

            public int getArea()
            {
                return width * height;
            }

            public int getPerimeter()
            {
                return 2 * (width + height);
            }

            public void move(int stepRight, int stepUp)
            {
                upperLeft.x += stepRight;
                upperLeft.y += stepUp;
            }
        }

        class Post
        {
            public string author;
            public string text;
            public int likes;
            public string[] comments;

            public void like()
            {
                likes += 1;
            }

            public int getLikesNumber()
            {
                return likes;
            }

            public void leaveComment(string comment)
            {
                if (comments == null)
                {
                    comments = new string[1];
                }
                else
                {
                    Array.Resize(ref comments, comments.Length + 1);
                }
                comments[comments.Length - 1] = comment;
            }

            public string[] getComments()
            {
                // for (int i = 0; i < comments.Length; i++)
                // {
                //     Console.WriteLine(comments[i]);
                // }
                return comments;
            }
        }

        static void Main(string[] args)
        {
            Rect rect = new Rect()
            {
                upperLeft = new Point() {x = 1, y = 3},
                width = 2,
                height = 5,
            };

            // perimeter = rect.getPerimeter();
            // Console.WriteLine(perimeter);
            // area = rect.getArea();
            // Console.WriteLine(area);
            // rect.move(3, 4);
            // Console.WriteLine(rect.upperLeft);

            Post post = new Post()
            {
                author = "AndriiV",
                text = "This is my first post",
                likes = 7,
            };

            post.getLikesNumber();
            post.like();
            int likes = post.getLikesNumber();
            Console.WriteLine(likes);

            post.leaveComment("first comment");
            post.getComments();
            post.leaveComment("second comment");
            post.getComments();
        }
    }
}