﻿namespace Server.HTTP
{
    public class Cookie
    {

        public Cookie(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }

        public Cookie(string cookiesAsString)
        {
            var cookieParts = cookiesAsString.Split(new char[] { '=' }, 2);

            this.Name = cookieParts[0];
            this.Value = cookieParts[1];
        }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}