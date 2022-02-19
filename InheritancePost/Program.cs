using InheritancePost;

bool postPublic;
Console.WriteLine("Enter your message");
string postMsg = Console.ReadLine();
Console.WriteLine("Enter your Username");
string postUser = Console.ReadLine();
Console.WriteLine("Make post public? Press Y/N");
string postInput = Console.ReadLine();
if (postInput.ToLower() == "y")
    postPublic = true;
else
{
    postPublic = false;
}

Post newPost = new Post(postMsg,postUser,postPublic);

newPost.Show();

Console.WriteLine("Enter your message");
postMsg = Console.ReadLine();
Console.WriteLine("Enter your Username");
postUser = Console.ReadLine();
Console.WriteLine("Enter Image URL:");
string postURL = Console.ReadLine();
Console.WriteLine("Make post public? Press Y/N");
postInput = Console.ReadLine();
if (postInput.ToLower() == "y")
    postPublic = true;

ImagePost newIMG = new ImagePost(postMsg, postUser, postPublic, postURL);

newIMG.Show();
