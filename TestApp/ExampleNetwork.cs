using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Org.Neuroph.Core;
using Org.Neuroph.Core.Learning;
using Org.Neuroph.Util;
using Org.Neuroph.Nnet;
using Org.Neuroph.Nnet.Learning;
using Android.Runtime;
using Android.Content.Res;
using Environment = Android.OS.Environment;

namespace TestApp
{
	public class ExampleNetwork
	{
		int inputSize = 8;
		int outputSize = 1;
		NeuralNetwork network;
		TrainingSet trainingSet;
		TrainingSet testingSet;
		int[] layers = { 8, 8, 1 };
		string results = "";
		string basePath = "/data/data/nofew.testapp/files";
		AssetManager assets;
		Java.IO.File destinationFile;

		public string Results
		{
			get { return results; }
			set { results = value; }
		}

		public ExampleNetwork(AssetManager inAssets, Java.IO.File inFile)
		{
			this.assets = inAssets;
			this.destinationFile = inFile;
		}
		public void LoadNetwork()
		{
			network = NeuralNetwork.Load( basePath + "/TrainTest.nnet");
		}

		public void TrainNetwork()
		{
			List<int> list = new List<int>();
			foreach (int layer in layers)
			{
				list.Add(layer);
			}
			Stream stream = assets.Open("Classroom_Occupation_Data.csv", Access.Random);
			StreamReader sr = new StreamReader(stream);
			string content = sr.ReadToEnd();
			StreamWriter destinationStream = new StreamWriter(basePath + "/Classroom_Occupation_Data.csv",false);
			destinationStream.Write(content);
			destinationStream.Flush();
			network = new MultiLayerPerceptron(TransferFunctionType.Sigmoid, list.ToArray());
			trainingSet = new TrainingSet(inputSize, outputSize);
			trainingSet = TrainingSet.CreateFromFile(basePath + "/Classroom_Occupation_Data.csv", inputSize, outputSize, ",");
			BackPropagation learningRule = new BackPropagation();
			network.LearningRule = learningRule;
			network.Learn(trainingSet);
			network.Save(basePath + "/TrainTest.nnet");
			destinationStream.Close();
			destinationStream.Dispose();
		}

		public void TestNetwork()
		{
			double total = 0.0;
			List<int> list = new List<int>();
			List<String> outputLine = new List<String>();
			foreach (int layer in layers)
			{
				list.Add(layer);
			}
			Stream stream = assets.Open("Classroom_Occupation_Test_Data.csv", Access.Random);
			StreamReader sr = new StreamReader(stream);
			string content = sr.ReadToEnd();
			StreamWriter destinationStream = new StreamWriter(basePath + "/Classroom_Occupation_Test_Data.csv", false);
			destinationStream.Write(content);
			destinationStream.Flush();
			testingSet = TrainingSet.CreateFromFile(basePath + "/Classroom_Occupation_Test_Data.csv", inputSize, outputSize, ",");
			int count = testingSet.Elements().Count;
			double averageDeviance = 0;
			String resultString = "";
			try
			{
				for (int i = 0; i < testingSet.Elements().Count; i++)
				{
					double expected;
					double calculated;
					network.SetInput(testingSet.ElementAt(i).GetInput());
					network.Calculate();
					calculated = network.GetOutput()[0];
					expected = testingSet.ElementAt(i).GetIdealArray()[0];
					averageDeviance += Math.Abs(Math.Abs(calculated) - Math.Abs(expected));
					total += network.GetOutput()[0];
					resultString = "";
					for (int cols = 0; cols < testingSet.ElementAt(i).GetInputArray().Length; cols++)
					{
						resultString += testingSet.ElementAt(i).GetInputArray()[cols] + ", ";
					}
					for (int t = 0; t < network.GetOutput().Length; t++)
					{
						resultString += network.GetOutput()[t] + ", ";
					}
					resultString = resultString.Substring(0, resultString.Length - 2);
					resultString += "";
				}
				Results = GetResults(count,total,averageDeviance);
			}
			catch (IOException ex)
			{
				Console.Error.WriteLine(ex.StackTrace);
			}
			destinationStream.Close();
			destinationStream.Dispose();
		}

		public string GetResults(int count, double total, double averageDeviance)
		{
			return "Average: " + total / count + "\n" +
				"Average Deviance: " + averageDeviance / count;
		}
}
}

