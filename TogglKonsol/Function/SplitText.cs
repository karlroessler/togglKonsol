namespace TogglKonsol
{
    public class SplitText : ISplitText
    {
        public string SplintOnFirst(string arg)
        {
            string text = null;
            string[] split = arg.Split(new char[] { ':' }, 2);
            if(split.Length > 1)
            {
                text = split[1];
            }
            return text;
        }
    }
}
