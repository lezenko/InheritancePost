using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePost
{
    public class ImagePost : Post
    {
        public string URL { get; set; }
        public ImagePost(string status, string byusername, bool ispublic, string url)
        {
            this.ID = IncrementID();
            this.Status = status;
            this.ByUsername = byusername;
            this.IsPublic = ispublic;

            this.URL = url;
        }
        public override void Show()
        {
            if (IsPublic)
            {
                Console.WriteLine($"{this.ID} -- {this.Status} -- {this.URL} -- by {this.ByUsername}");
            }
            else
            {
                Console.WriteLine("This post is not set to public");
            };
        }
    }
}
