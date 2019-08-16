namespace ValidateParameterProblemS3900
{
    using System;
    using System.IO;

    public class Class1
    {
        public string Foo(string name)
        {
            if (name == null)
            {
                name = Guid.NewGuid().ToString("N");
            }

            return string.Join("_", name.Split(Path.GetInvalidFileNameChars()));
        }
    }
}
