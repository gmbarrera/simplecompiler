using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleCompiler
{
    public class Tokenizer
    {
        private List<TokenInfo> tokenInfos;
        private List<Token> tokens;

        public Tokenizer()
        {
            tokenInfos = new List<TokenInfo>();
            tokens = new List<Token>();
        }

        class TokenInfo
        {
            public Regex regex;
            public int token;

            public TokenInfo(Regex regex, int token)
            {
                this.regex = regex;
                this.token = token;
            }
        }
        public class Token
        {
            public int token;
            public String sequence;

            public Token(int token, String sequence)
            {
                this.token = token;
                this.sequence = sequence;
            }
        }

        public void Add(String regex, int token)
        {
            tokenInfos.Add(new TokenInfo(new Regex("^(" + regex + ")"), token));
        }

        public void Tokenize(String str)
        {
            String s = str.Trim();
            tokens.Clear();
            while (!s.Equals(""))
            {
                bool match = false;
                foreach (TokenInfo info in tokenInfos)
                {
                    var m = info.regex.Match(s);
                    if (m.Success)
                    {
                        match = true;
                        String tok = m.Value.Trim();
                        s = s.Remove(m.Index, m.Length).Trim();
                        tokens.Add(new Token(info.token, tok));
                        break;
                    }
                }
                if (!match) throw new Exception("Unexpected character in input: " + s);
            }
        }
        public List<Token> GetTokens()
        {
            return tokens;
        }
    }
}