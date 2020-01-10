using System;
using System.Collections.Generic;
//using System.Linq;

namespace ND2
{
    class Program
    {
        static void Main()
        {
            List<int> skaiciai = new List<int>();

               foreach (int item in sugeneruotiSesiazenkliusSkaicius(skaiciai))
               {
                if (IsArrayValuesUnique(ConvertIntToIntArray(item)))
                {
                         int padaugintaIs2 = item * 2;
                         int padaugintaIs3 = item * 3;
                         int padaugintaIs4 = item * 4;
                         int padaugintaIs5 = item * 5;
                         int padaugintaIs6 = item * 6;

                        if (DoTwoArraysHaveSameElementsButInDifferentIndexes(ConvertIntToIntArray(item), ConvertIntToIntArray(padaugintaIs2)) &&
                            DoTwoArraysHaveSameElementsButInDifferentIndexes(ConvertIntToIntArray(item), ConvertIntToIntArray(padaugintaIs3)) &&
                            DoTwoArraysHaveSameElementsButInDifferentIndexes(ConvertIntToIntArray(item), ConvertIntToIntArray(padaugintaIs4)) &&
                            DoTwoArraysHaveSameElementsButInDifferentIndexes(ConvertIntToIntArray(item), ConvertIntToIntArray(padaugintaIs5)) &&
                            DoTwoArraysHaveSameElementsButInDifferentIndexes(ConvertIntToIntArray(item), ConvertIntToIntArray(padaugintaIs6)))
                        {
                            Console.WriteLine("Magiškas sesiazenklis skaicius yra: " + item);
                        }               
                }
                } 
               }

            static int[] ConvertIntToIntArray(int skaicius)
            {
                string laikinas = skaicius.ToString();
                int[] skaiciuMasyvas = new int[laikinas.Length];
                for (int i = 0; i < laikinas.Length; i++)
                {
                    char simbolis = laikinas[i];
                    int skaiciusSk = int.Parse(simbolis.ToString());
                    skaiciuMasyvas[i] = skaiciusSk;

                }
                return skaiciuMasyvas;
            }
        
            static bool IsArrayValuesUnique(int[] skaiciuMasyvas)
            {
                for (int i = 0; i < skaiciuMasyvas.Length; i++)
                {
                    for (int j = i + 1; j < skaiciuMasyvas.Length; j++)
                    {
                        if (skaiciuMasyvas[i] == skaiciuMasyvas[j])
                        {
                             return false;
                        }
                    }
                }
              return true;
                
                /*  su linqu  butu        
                 *                 List<int> laikinasListas = new List<int>();
                                   laikinasListas.AddRange(skaiciuMasyvas);
                 *  
                 *  
                  if (laikinasListas.Distinct().Count() == laikinasListas.Count())
                   {
                      return true;
                  }
                  return false;
                */
            }



            static bool DoTwoArraysHaveSameElementsButInDifferentIndexes(int[] skaiciuMasyvas, int[] skaiciuMasyvas2)
            {
                if (skaiciuMasyvas.Length == skaiciuMasyvas2.Length)
                {
                    List<int> listDiff = new List<int>();

                    int[] pirmasLaikinasMasyvas = (int[])skaiciuMasyvas.Clone();
                    int[] antrasLaikinasMasyvas = (int[])skaiciuMasyvas2.Clone();
                    Array.Sort(pirmasLaikinasMasyvas);
                    Array.Sort(antrasLaikinasMasyvas);

                    for (int i = 0; i < pirmasLaikinasMasyvas.Length; i++)
                    {
                        if (pirmasLaikinasMasyvas[i] != antrasLaikinasMasyvas[i])
                        {
                            return false;
                        }
                    }

                    for (int k = 0; k < skaiciuMasyvas.Length; k++)
                    {
                        if (skaiciuMasyvas[k] != skaiciuMasyvas2[k])
                        {
                            listDiff.Add(k);
                        }
                    }

                    if (listDiff.Count == skaiciuMasyvas.Length)
                    {
                        return true;
                    }
                    return false;
                }           
                return false;

                /* su linqu butu tik tiek:
                if (skaiciuMasyvas.Count() == skaiciuMasyvas2.Count() && !skaiciuMasyvas.Except(skaiciuMasyvas2).Any())
                {
                    return true;
                }
                return false;
                */
            }


            static List<int> sugeneruotiSesiazenkliusSkaicius(List<int> skaiciai)
            {
                for (int i = 100000; i < 1000000; i++)
                {
                    skaiciai.Add(i);
                }
            return skaiciai;
            }

        }
    }
    

