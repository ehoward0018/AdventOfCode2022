using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    internal class Day13
    {
        //static void Main()
        //{
        //    var path2 = Path.Combine(Directory.GetCurrentDirectory(), "Day13.txt");
        //    string[] inputs = File.ReadAllLines(path2);


        //    string leftP;
        //    string rightP;
        //    int index = 0;
        //    int total = 0;

        //    for(int i = 0; i < inputs.Length; i += 3)
        //    {
        //        index++;
        //        leftP = inputs[i];
        //        rightP = inputs[i + 1];
        //        answerFound = false;
        //        packetsInRightOrder = false;
        //        PacketsInRightOrder(leftP, rightP);
        //        if (packetsInRightOrder) total += index;
        //        Debug.WriteLine($"Total: {total}, I: {i}");
        //        Debug.WriteLine(" ");
        //    }

        //}
        static bool answerFound = false;
        static bool packetsInRightOrder = false;

        static void PacketsInRightOrder(string leftP, string rightP)
        {
            Debug.WriteLine(leftP);
            Debug.WriteLine(rightP);
            Debug.WriteLine(" ");
            if (answerFound) return;
            if (leftP.Length == 0 && rightP.Length == 0) return;
            if (leftP.Length > 0 && rightP.Length == 0)
            {
                answerFound = true;
                return;
            }
            if (leftP.Length == 0 && rightP.Length > 0)
            {
                packetsInRightOrder = true;
                answerFound = true;
                return;
            }
            if (leftP[0] != '[' && rightP[0] != '[')
            {
                ComparePackets(leftP, rightP);
            }
            else if (leftP[0] != '[' && rightP[0] == '[')
            {
                leftP = RepairPacket(leftP);
                PacketsInRightOrder(leftP, rightP);
            }
            else if (leftP[0] == '[' && rightP[0] != '[')
            {
                rightP = RepairPacket(rightP);
                PacketsInRightOrder(leftP, rightP);
            }
            else
            {
                leftP = leftP.Substring(1, leftP.Length - 2);
                rightP = rightP.Substring(1,rightP.Length - 2);
                List<string> leftPacket = new();
                List<string> rightPacket = new();
                PreparePacket(leftP, leftPacket);
                PreparePacket(rightP, rightPacket);

                if (leftPacket.Count > rightPacket.Count)
                {
                    for(int i = 0; i < leftPacket.Count; i++)
                    {
                        PacketsInRightOrder(leftPacket[i], rightPacket[i]);
                        if (answerFound) break;
                    }
                    if (!answerFound)
                    {
                        packetsInRightOrder = true;
                        answerFound = true;
                    }
                }
                else if (rightPacket.Count > leftPacket.Count)
                {
                    for (int i = 0; i < rightPacket.Count; i++)
                    {
                        PacketsInRightOrder(leftPacket[i], rightPacket[i]);
                        if (answerFound) break;
                    }
                    if (!answerFound)
                    {
                        answerFound = true;
                    }
                }
                else
                {
                    for (int i = 0; i < leftPacket.Count; i++)
                    {
                        PacketsInRightOrder(leftPacket[i], rightPacket[i]);
                        if (answerFound) break;
                    }
                }
                //PacketsInRightOrder(leftPacket[0], rightPacket[0]);
            }
        }

        static void PreparePacket(string packet, List<string> packetList)
        {
            int counter = 0;
            int sectionStart = 0;
            if (packet.Length == 0)
            {
                packetList.Add("");
                return;
            }
            for (int i = 0; i < packet.Length; i++)
            {
                if (packet[i] == '[') counter++;
                else if (packet[i] == ']') counter--;
                if (counter == 0)
                {
                    if (sectionStart == i)
                    {
                        int toStartCounter = 1;
                        for (int j = i + 1; j < packet.Length; j++)
                        {
                            if (packet[j] == ',' && packet[j+1] == '[') break;
                            toStartCounter++;
                        }
                        packetList.Add(packet.Substring(sectionStart, i - sectionStart + toStartCounter));
                        sectionStart = i + toStartCounter;
                        i += toStartCounter;
                    }
                    else
                    {
                        int toStartCounter = 2;
                        for (int j = i; j < packet.Length; j++)
                        {
                            if (packet[j] == ',') break;
                            toStartCounter++;
                        }
                        packetList.Add(packet.Substring(sectionStart, i - sectionStart + 1));
                        sectionStart = i + toStartCounter;
                        i += toStartCounter;
                    }
                }
            }
        }

        static string RepairPacket(string packet)
        {
            return $"[{packet}]";
        }
        
        static void ComparePackets(string leftP, string rightP)
        {
            if (!string.IsNullOrEmpty(leftP) && !string.IsNullOrEmpty(leftP))
            {
                string[] leftValues;
                string[] rightValues;
                if (leftP.Contains(',')) leftValues = leftP.Split(',');
                else leftValues = new string[1] { leftP };
                if (rightP.Contains(',')) rightValues = rightP.Split(',');
                else rightValues = new string[1] { rightP };
                
                if (leftValues.Length > rightValues.Length) 
                { 
                    for(int i = 0; i < rightValues.Length; i++)
                    {
                        int left = int.Parse(leftValues[i]);
                        int right = int.Parse(rightValues[i]);
                        if (left > right)
                        {
                            answerFound = true;
                            return;
                        }
                        else if (right > left)
                        {
                            packetsInRightOrder = true;
                            answerFound = true;
                            return;
                        }
                    }
                    answerFound = true;
                    return;
                }
                else if (rightValues.Length > leftValues.Length)
                {
                    for (int i = 0; i < leftValues.Length; i++)
                    {
                        int left = int.Parse(leftValues[i]);
                        int right = int.Parse(rightValues[i]);
                        if (left > right)
                        {
                            answerFound = true;
                            return;
                        }
                        else if (right > left)
                        {
                            packetsInRightOrder = true;
                            answerFound = true;
                            return;
                        }
                    }
                    packetsInRightOrder = true;
                    answerFound = true;
                    return;
                }
                for (int i = 0; i < leftValues.Length; i++)
                {
                    int left = int.Parse(leftValues[i]);
                    int right = int.Parse(rightValues[i]);
                    if (left > right)
                    {
                        answerFound = true;
                        return;
                    }
                    else if (right > left)
                    {
                        packetsInRightOrder = true;
                        answerFound = true;
                        return;
                    }
                }
            }
        }
    }
}
