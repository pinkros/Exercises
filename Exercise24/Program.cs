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
//int count = 0;
//for (int i = 0; i < 4; i++)
//{
//    for (int j = 0; j < 7; j++)
//    {
//        if (j == count)
//        {
//            for (int k = 0; k < 2; k++)
//            {
//                Console.Write("#"); 
//            }

//        }
//        else
//        {
//            Console.Write("-");
//        }

//    }
//    count += 2;
//    Console.Write("\n");
//}

//d.
//--#--#--
//--#--#--
//########
//--#--#--

//for (int i = 0; i < 4; i++)
//{
//    for (int j = 0; j < 8; j++)
//    {
//        if (i == 2 || j == 2 || j == 5)
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

//e.
//#---#---
//-#-#----
//--#-----
//-#-#----

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 8; j++)
    {
        if (i == 2 || j == 2 || j == 5)
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