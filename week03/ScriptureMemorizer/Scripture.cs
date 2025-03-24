﻿namespace ScriptureMemorizer
{
    class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();

            string[] parts = text.Split(' ');

            foreach (string part in parts)
            {
                _words.Add(new Word(part));
            }
        }

        public void HideRandomWords(int numberToHide)
        {
            Random random = new Random();
            int hidden = 0;

            while (hidden < numberToHide)
            {
                int index = random.Next(_words.Count);
                Word word = _words[index];

                if (!word.IsHidden())
                {
                    word.Hide();
                    hidden++;
                }
            }
        }

        public string GetDisplayText()
        {
            string display = _reference.GetDisplayText() + "\n\n";

            foreach (Word word in _words)
            {
                display += word.GetDisplayText() + " ";
            }

            return display.TrimEnd();
        }

        public bool IsCompletelyHidden()
        {
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
