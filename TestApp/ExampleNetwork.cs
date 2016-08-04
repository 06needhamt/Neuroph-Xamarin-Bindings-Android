using System;
using System.IO;
using System.Collections.Generic;
using Android.App;
using Android.Widget;
using Android.OS;
using Org.Neuroph.Core;
using Org.Neuroph.Core.Learning;
using Org.Neuroph.Util;
using Org.Neuroph.Nnet;
using Org.Neuroph.Nnet.Learning;
using Java.Lang;

using Math = System.Math;
using String = System.String;

namespace TestApp
{
	public static class TestNetwork
	{
		static int inputSize = 8;
		static int outputSize = 1;
		static NeuralNetwork network;
		static TrainingSet trainingSet;
		static TrainingSet testingSet;
		static int[] layers = { 8, 8, 1 };

		public static void loadNetwork()
		{
			network = NeuralNetwork.Load("D:/GitHub/Neuroph-Intellij-Plugin/TrainTest.nnet");
		}

		public static void trainNetwork()
		{
			List<Integer> list = new List<Integer>();
			foreach (Integer layer in layers)
			{
				list.Add(layer);
			}

			network = new MultiLayerPerceptron(list, TransferFunctionType.Sigmoid);
			trainingSet = new TrainingSet(inputSize, outputSize);
			trainingSet = TrainingSet.CreateFromFile("D:/GitHub/NeuralNetworkTest/Classroom Occupation Data.csv", inputSize, outputSize, ",");
			BackPropagation learningRule = new BackPropagation();
			network.LearningRule = learningRule;
			network.Learn(trainingSet);
			network.Save("D:/GitHub/Neuroph-Intellij-Plugin/TrainTest.nnet");
		}

		public static void testNetworkAuto(String setPath)
		{
			double total = 0.0;
			List<Integer> list = new List<Integer>();
			List<String> outputLine = new List<String>();
			foreach (Integer layer in layers)
			{
				list.Add(layer);
			}

			testingSet = TrainingSet.CreateFromFile(setPath, inputSize, outputSize, ",");
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
			}
			catch (IOException ex)
			{
				Console.Error.WriteLine(ex.StackTrace);
			}
		}

		public static double[] GetResults(int count, double total, double averageDeviance)
		{
			return new double[] { (total / count), (averageDeviance / count) };
		}
}
}

