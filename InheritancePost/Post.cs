using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePost
{
    public class Post
    {
        private int idNumber;
        protected int ID { get; set; }
        protected string Status { get; set; }
        protected string ByUsername { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Status = "Write your message! How's your day going?";
            ByUsername = "The Computer!";
            IsPublic = true;

        }
        public Post(string status, string byusername, bool ispublic)
        {
            this.ID = IncrementID();
            this.Status = status;
            this.ByUsername = byusername;
            this.IsPublic = ispublic;
        }

        protected int IncrementID()
        {
            return ++idNumber;
        }

        public void Update(string status, bool ispublic)
        {
            this.Status = status;
            this.IsPublic = ispublic;
        }

        public virtual void Show()
        {
            if (IsPublic)
            {
                Console.WriteLine($"{this.ID} -- {this.Status} -- by {this.ByUsername}");
            } else
            {
                Console.WriteLine("This post is not set to public");
            }

        }
    }
}
