namespace kozossegi_oldal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextPost post1 = new TextPost("Alice", "This is a short text post.");
            TextPost post2 = new TextPost("Bob", "This is a longer text post that exceeds 100 characters. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
            post1.Like();
            post1.Like();
            post1.Like();
            Console.WriteLine(post1.GetDescription());
            Console.WriteLine(post1.Score());
            Console.WriteLine(post2.GetDescription());
            Console.WriteLine(post2.Score());

            ImagePost imagePost1 = new ImagePost("Charlie", 3);
            imagePost1.Like();
            imagePost1.Like();
            imagePost1.Like();
            imagePost1.Like();
            imagePost1.Like();
            Console.WriteLine(imagePost1.GetDescription());
            Console.WriteLine(imagePost1.Score());

            ImagePost imagePost2 = new ImagePost("Dave", 15);
            Console.WriteLine(imagePost2.GetDescription());

            PollPost pollPost1 = new PollPost("Anna");
            pollPost1.Like();
            pollPost1.Like();
            pollPost1.Vote();
            pollPost1.Vote();
            pollPost1.Vote();
            pollPost1.Vote();
            pollPost1.Close();

            pollPost1.Like();
            pollPost1.Vote();
            Console.WriteLine(pollPost1.Score());
            Console.WriteLine(pollPost1.GetDescription());

            post2.AddComment("Eve", "This is a comment.");
            Comment tizedikfeladathoz = post2.AddComment("Frank", "This is another comment.");
            Console.WriteLine(tizedikfeladathoz.GetDescription());
            foreach (Comment comment in post2.Comments)
            {
                Console.WriteLine(comment.GetDescription());
            }



        }
    }
}
