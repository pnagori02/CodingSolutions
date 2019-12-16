using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        class TrieNode
        {
            // Initialize your data structure here.
            public char Data;
            public bool IsEnd;
            public Dictionary<char, TrieNode> Neighbors;
            public TrieNode()
            {
                this.Data = '#';
                this.IsEnd = true;
                this.Neighbors = new Dictionary<char, TrieNode>();
            }

            public TrieNode(char ch)
            {
                this.Data = ch;
                this.IsEnd = false;
                this.Neighbors = new Dictionary<char, TrieNode>();
            }
        }

        public class Trie
        {
            private readonly TrieNode root;

            public Trie()
            {
                root = new TrieNode();
            }

            public void Insert(String word)
            {
                var start = root;
                foreach (var ch in word)
                {
                    if (!start.Neighbors.ContainsKey(ch))
                    {
                        var newnode = new TrieNode(ch);
                        start.Neighbors.Add(ch, newnode);
                    }

                    start = start.Neighbors[ch];
                }

                start.IsEnd = true;
            }

            // Returns if the word is in the trie.
            public bool Search(string word)
            {
                var start = root;
                foreach (var ch in word)
                {
                    if (!start.Neighbors.ContainsKey((ch)))
                    {
                        return false;
                    }

                    start = start.Neighbors[ch];
                }

                return start.IsEnd;
            }

            // Returns if there is any word in the trie
            // that starts with the given prefix.
            public bool StartsWith(string word)
            {
                var start = root;
                foreach (var ch in word)
                {
                    if (!start.Neighbors.ContainsKey((ch)))
                    {
                        return false;
                    }

                    start = start.Neighbors[ch];
                }

                return true;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Trie t = new Trie();
            t.Insert("prashant");
            t.Insert("pram");
            t.Insert("pratham");
            t.Insert("pankaj");
            Hashtable ht = new Hashtable();
            var stringList = new List<string>();
            string mainString = "abc";
            for (int length = 1; length < mainString.Length; length++)
            {
                for (int start = 0; start <= mainString.Length - length; start++)
                {
                    var substring = mainString.Substring(start, length);
                    stringList.Add(substring);
                }
            }

        }
    }
}
