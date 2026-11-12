using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kozossegi_oldal
{
    public class TextPost : Post
    {
        private string _text;
        public string Text { get { return _text; } set { _text = value; } }

        public TextPost(string author, string text) : base(author)
        {
            _text = text;
        }

        public override int Score()
        {
            return Likes;
        }
        public override string GetDescription()
        {
            if(Text.Length > 20)
            {
                return base.GetDescription() + $" Text: {Text.Substring(0, 20)}...";
            }
            else
            {
                return base.GetDescription() + $" Text: {Text}";
            }
        }


    }
}
