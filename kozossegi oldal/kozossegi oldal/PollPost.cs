using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kozossegi_oldal
{
    public class PollPost : Post
    {
        private int _votes;
        private bool _isClosed;
        public int Votes { get { return _votes; } }
        public bool IsClosed { get { return _isClosed; } }

        public PollPost(string author) : base(author)
        {
            _votes = 0;
            _isClosed = false;
        }
        public bool Vote()
        {
            if (!_isClosed)
            {
                _votes++;
                return true;
            }
            return false;
        }
        public void Close()
        {
            _isClosed = true;
        }
        public override int Score()
        {
            return Likes + Votes;
        }
        public override string GetDescription()
        {
            return $"{Author}, {Likes} kedvelés, {Votes} szavazat, {(IsClosed ? "Lezárt" : "Nyitott")}";
        }
        public override bool Like()
        {
            if (_isClosed)
            {
                return false;
            }
            else
            {
                
                return base.Like();
            }
                
        }
    }
}
