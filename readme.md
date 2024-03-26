# Recursive Sorting Algorithms

This solution provides implementations of various sorting algorithms using recursive approaches.

## Algorithms Implemented

1. **Bubble Sort (Recursive)**
2. **Selection Sort (Recursive)**
3. **Insertion Sort (Recursive)**
4. **Merge Sort (Recursive)**
5. **Quick Sort**

## Instructions

Each sorting algorithm is implemented as a static method within the `ArraySort` class. Below are brief instructions on how to use each algorithm:

### 1. Bubble Sort (Recursive)

```csharp
ArraySort.BubbleSortRecursive(array, array.Length);
```

### 2. Selection Sort (Recursive)

```csharp
ArraySort.SelectionSortRecursive(array, 0);
```

### 3. Insertion Sort (Recursive)

#### By Index:

```csharp
ArraySort.InsertionSortRecursiveByIndex(array, 1);
```

#### By Length:

```csharp
ArraySort.InsertionSortRecursiveByLength(array, array.Length);
```

### 4. Merge Sort

```csharp
ArraySort.MergeSort(array, 0, array.Length - 1);
```

### 5. Quick Sort

```csharp
ArraySort.QuickSort(array, 0, array.Length - 1);
```

### Binary Search (Not a Sorting Algorithm)

This method is included in the solution but is not part of the sorting algorithms. It performs a binary search on a sorted array.

```csharp
ArraySort.BinarySearch(sortedArray);
```

## Example Usage

```csharp
int[] array = { 5, 3, 8, 4, 2, 7, 1, 6 };
ArraySort.MergeSort(array, 0, array.Length - 1);
ArraySort.Show(array); // Output: 1 2 3 4 5 6 7 8
```

## Note

Make sure to replace `array` with the array you want to sort in the example usage. Also, ensure that the array is properly initialized before passing it to any of the sorting methods.
