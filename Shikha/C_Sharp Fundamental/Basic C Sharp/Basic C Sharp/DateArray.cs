using System;

namespace Basic_C_Sharp
{
    #region
    //NAME          :- DateArray
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- Sorting of date
    //CREATED DATE  :- 18/07/2012  

    class DateArray
    {

        //NAME          :- dateArray
        //AUTHOR        :- SHIKHA MALIK
        //DESCRIPTION   :- Sorting of date
        //CREATED DATE  :- 18/07/2012  

        public void dateArray(StructDate[] d)
        {
            StructDate objtemp;
            try
            {
                objtemp = new StructDate();
                for (
                    int i = 0; i < d.Length; i++)
                {
                    for (int j = i + 1; j < d.Length; j++)
                    {
                        if (d[i].Year < d[j].Year) { }
                        else if (d[i].Year > d[j].Year)//check Year
                        {
                            objtemp = d[j]; d[j] = d[i];
                            d[i] = objtemp;
                        }
                        else///check Month
                        {
                            if (d[i].Month < d[j].Month) { }
                            else if (d[i].Month > d[j].Month)
                            {
                                objtemp = d[j]; d[j] = d[i];
                                d[i] = objtemp;
                            }
                            else //check Day 
                            {
                                if (d[i].Day < d[j].Day) { }
                                else if (d[i].Day > d[j].Day)
                                {
                                    objtemp = d[j]; d[j] = d[i];
                                    d[i] = objtemp;
                                }
                                else { }
                            }
                        }
                    }
                }
                Console.WriteLine("Sorted By Value\n");
                for (int i = 0; i < d.Length; i++)
                {
                    Console.WriteLine(d[i].Day + "/" + d[i].Month + "/" + d[i].Year);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("invalide");
                Console.ReadLine();
            }
        }
        public void dateArray(ref StructDate[] d)
        {
          StructDate objtemp;
          try
          {
              objtemp = new StructDate();
              for (int i = 0; i < d.Length; i++)
              {
                  for (int j = i + 1; j < d.Length; j++)
                  {
                      if (d[i].Year < d[j].Year) { }
                      else if (d[i].Year > d[j].Year)//check Year
                      {
                          objtemp = d[j]; d[j] = d[i];
                          d[i] = objtemp;
                      }
                      else///check Month
                      {
                          if (d[i].Month < d[j].Month) { }
                          else if (d[i].Month > d[j].Month)
                          {
                              objtemp = d[j]; d[j] = d[i];
                              d[i] = objtemp;
                          }
                          else //check Day 
                          {
                              if (d[i].Day < d[j].Day) { }
                              else if (d[i].Day > d[j].Day)
                              {
                                  objtemp = d[j]; d[j] = d[i];
                                  d[i] = objtemp;
                              }
                              else { }
                          }
                      }
                  }
              }
              Console.WriteLine("Sorted By Refrence\n");
              for (int i = 0; i < d.Length; i++)
                  Console.WriteLine(d[i].Day + "/" + d[i].Month + "/" + d[i].Year);  // print Sorted date 
          }
          catch (Exception)
          {
              Console.WriteLine("invalide");                                   //throw exception if invalid date
              Console.ReadLine();
          }
         
        }
    }
    #endregion
}
