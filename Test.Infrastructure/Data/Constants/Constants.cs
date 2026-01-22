using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Infrastructure.Data.Constants
{
    public class Constants
    {
        public static class UserConstraints
        {
            public const int UserNameMaxLength = 150;
            public const int BioMaxLength = 500;
        }

        public static class PostConstraints
        {
            public const int ContentMaxLength = 300;
        }

        public static class MessageConstraints
        {
            public const int ConstentMaxLength = 1000;
        }
    }
}
