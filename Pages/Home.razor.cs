using TextTools.Model;

namespace TextTools.Pages
{
    public partial class Home
    {
        private readonly List<Tool> _basicTools = [];
        private readonly List<Tool> _textManipulationTools = [];
        public Home()
        {
            BasicTools();
            TextManipulation();
        }

        private void BasicTools()
        {
            _basicTools.Clear();
            _basicTools.Add(new Tool()
            {
                Heading = "Sort Text",
                ShortDescrption = "Sort a list in alphabetical, natural, reverse, or random order.",
                ImageUrl = "https://picsum.photos/150",
                PageUri = "Workers/basic/sortText"
            });
            _basicTools.Add(new Tool()
            {
                Heading = "Convert Case",
                ShortDescrption = "Change the letter case to uppercase, lowercase, title case, sentence case, or capitalize.",
                ImageUrl = "https://picsum.photos/150",
                PageUri = "Workers/basic/caseconverter"
            });
            _basicTools.Add(new Tool()
            {
                Heading = "Find & Replace",
                ShortDescrption = "Find all the instances the text appears in a text and replace it with another word.",
                ImageUrl = "https://picsum.photos/150",
                PageUri = "Workers/basic/findandreplace"
            });
            _basicTools.Add(new Tool()
            {
                Heading = "Reverse List",
                ShortDescrption = "Flip a list vertically to transform a list in reverse order.",
                ImageUrl = "https://picsum.photos/150"
            });
            _basicTools.Add(new Tool()
            {
                Heading = "Difference Checker",
                ShortDescrption = "Compare text files and find the difference between the two.",
                ImageUrl = "https://picsum.photos/150"
            });
            _basicTools.Add(new Tool()
            {
                Heading = "Word Count",
                ShortDescrption = "Find out how many words, sentences, paragraphs, and characters you have written.",
                ImageUrl = "https://picsum.photos/150",
                PageUri = "sortText"
            });
            _basicTools.Add(new Tool()
            {
                Heading = "CSV Tools",
                ShortDescrption = "Text Operation on csv files.",
                ImageUrl = "https://picsum.photos/150",
                PageUri = "csveditor"
            });
        }

        private void TextManipulation()
        {
            _textManipulationTools.Clear();
            _textManipulationTools.Add(new Tool()
            {
                Heading = "Sort Text",
                ShortDescrption = "Sort a list in alphabetical, natural, reverse, or random order.",
                ImageUrl = "https://picsum.photos/150"
            });
            _textManipulationTools.Add(new Tool()
            {
                Heading = "Convert Case",
                ShortDescrption = "Change the letter case to uppercase, lowercase, title case, sentence case, or capitalize.",
                ImageUrl = "https://picsum.photos/150"
            });
            _textManipulationTools.Add(new Tool()
            {
                Heading = "Find & Replace",
                ShortDescrption = "Find all the instances the text appears in a text and replace it with another word.",
                ImageUrl = "https://picsum.photos/150"
            });
            _textManipulationTools.Add(new Tool()
            {
                Heading = "Reverse List",
                ShortDescrption = "Flip a list vertically to transform a list in reverse order.",
                ImageUrl = "https://picsum.photos/150"
            });
            _textManipulationTools.Add(new Tool()
            {
                Heading = "Difference Checker",
                ShortDescrption = "Compare text files and find the difference between the two.",
                ImageUrl = "https://picsum.photos/150"
            });
            _textManipulationTools.Add(new Tool()
            {
                Heading = "Word Count",
                ShortDescrption = "Find out how many words, sentences, paragraphs, and characters you have written.",
                ImageUrl = "https://picsum.photos/150"
            });
        }
    } 
}

