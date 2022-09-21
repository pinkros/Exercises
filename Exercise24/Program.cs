//a.
//#-------
//-#------
//--#-----
//---#----
//for (int i = 0; i < 4; i++)
//{
//	for (int j = 0; j < 8; j++)
//	{
//        if (i == j)
//        {
//            Console.Write("#");
//        }
//        else
//        {
//            Console.Write("-");
//        }


//    }
//    Console.Write("\n");
//}

//b.
//#---#---
//-#---#--
//--#---#-
//---#---#

//for (int i = 0; i < 4; i++)
//{
//    for (int j = 0; j < 8; j++)
//    {
//        if (i == j)
//        {
//            Console.Write("#");
//        }

//        else if (j == i+4)
//        {
//            Console.Write("#");
//        }
//        else
//        {
//            Console.Write("-");
//        }


//    }
//    Console.Write("\n");
//}

//c.
//##------
//--##----
//----##--
//------##
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 8; j++)
    {
        if (i == j)
        {
            Console.Write("#");
        }
        else if (j == i + 1)
        {
            Console.Write("#");
        }
        else
                {
            Console.Write("-");
        }


    }
    Console.Write("\n");
}
