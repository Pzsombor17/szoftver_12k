using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kozossegi_oldal
{
    public class ImagePost : Post
    {
        private int _imageCount;
        public int ImageCount
        {
            get { return _imageCount; }
            set
            {
                if (value > 0 && value < 11)
                {
                    _imageCount = value;
                }
                else
                {
                    _imageCount = 1;
                }
            }
        }

        public ImagePost(string author, int imageCount) : base(author)
        {
            ImageCount = imageCount;
        }   
        public override int Score()
        {
            return Likes * 2;
        }
        public override string GetDescription()
        {
            return $"{Author}, {Likes} kedvelés";
        }

    }
}
