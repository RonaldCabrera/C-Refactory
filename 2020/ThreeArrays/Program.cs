using ThreeArrays;

var intArray = ArrayService.SetNumbersUntilTarget(5);
ArrayService.SumArrayValues(intArray);

intArray = ArrayService.SetNumbersUntilTarget(7);
ArrayService.ArrayContainsTargetValue(intArray, 23);

intArray = ArrayService.SetNumbersUntilTarget(10);
ArrayService.SumEvenOddArrayValues(intArray);