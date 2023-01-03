namespace HelloDocfx
{
    /// <summary>
    /// Hello this is **Class1** from *HelloDocfx*
    /// </summary>
    public class Class1
    {
        private InnerClass _class;
        public int Value { get; }

        /// <summary>
        /// This is a ctor
        /// </summary>
        /// <param name="value">The value of the class</param>
        public Class1(int value)
        {
            Value = value;
        }

        /// <summary>
        /// This is a ctor
        /// </summary>
        /// <param name="value">The value of the class</param>
        public Class1(bool value)
        {
           bool Values = value;
        } /// <summary>
          /// This is a ctor
          /// </summary>
          /// <param name="value">The value of the class</param>
        public Class1(string value)
        {
           string  sValue = value;
        } /// <summary>
          /// This is a ctor
          /// </summary>
          /// <param name="value">The value of the class</param>
        public Class1(double value)
        {
            double dValue = value;
        }

        /// <summary>
        /// fadfa
        /// </summary>
        /// <returns>fff</returns>
        public double ConvertToDouble()
        {
            return Value;
        }

        /// <summary>
        /// A method referencing a inner class
        /// </summary>
        /// <param name="name">The name</param>
        /// <param name="inner">A inner class with type <seealso cref="InnerClass"/></param>
        public void SetInnerClass(string name, InnerClass inner)
        {
            inner.Name = name;
            _class = inner;
        }
      

        /// <summary>
        /// fdfdfdf
        /// </summary>
        /// <param name="name">dfdfd</param>
        /// <param name="inner">dfdfd</param>
        public void SetInnerClass1(string name, InnerClass inner)
        {
            inner.Name = name;
            _class = inner;
        }

        public class InnerClass
        {
            public string Name { get; set; }
        }
    }
}
