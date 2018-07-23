﻿using System;
using DMS.GrpcTest.Protocol;

namespace DMS.GrpcTest.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMsgSumReply msgSum = MsgServiceClient.GetSum(10, 2);

            Console.WriteLine("grpc Client Call GetSum():" + msgSum.Sum);

            Console.WriteLine("任意键退出...");
            Console.ReadKey();
        }
    }
}
