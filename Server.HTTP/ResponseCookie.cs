using System;
using System.Text;

namespace Server.HTTP
{
    public class ResponseCookie : Cookie
    {
        public ResponseCookie(string name, string value)
            : base(name, value)
        {
            this.Path = "/";
        }


        public int MaxAge { get; set; }

        public string Domain { get; set; }

        public string Path { get; set; }

        public bool HttpOnly { get; set; }

        public override string ToString()
        {
            StringBuilder cookieBuilder = new StringBuilder();

            cookieBuilder.Append($"{this.Name}={this.Value}; Path={this.Path};");

            if (MaxAge != 0) cookieBuilder.Append($" Max-Age={this.MaxAge};");

            if (HttpOnly) cookieBuilder.Append($" HttpOnly;");

            return cookieBuilder.ToString();
        }
    }
}
