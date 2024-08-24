List<Task<int>> listTasks =
    [
        new Task<int>(() => Diff([2, 4, 6, 8], 0, 3)),
        new Task<int>(() => Diff([7, 3, 8], 0, 2)),
        new Task<int>(() => Diff([15, 17, 22, 47, 118, 170], 0, 5)),
        new Task<int>(() => Diff([88, 15, 26, 543, 276, 359, 111, 2], 0, 6)),
        new Task<int>(() => Diff([9, 15, 78], 0, 2))
    ];

for (int i = 0; i<listTasks.Count; i++)
{
    listTasks[i].Start();
}

for (int i = 0; i < listTasks.Count; i++)
{
    Console.WriteLine(listTasks[i].Result);
}


int Diff(List<int> list, int left, int right)
{
    int diff = 0;
    for (int i = 0; i < list.Count; i++)
    {
        diff -= list[i];
    }

    return diff;
}

