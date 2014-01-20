#LinkedListQueueRepo
===================

A linked list using nodes, written and unit tested in C# with Visual Studio 2010's integrated testing framework.

### Usage

Each node can be constructed with a name, with a reference to a next node, with both, or with neither. Each linked list queue can Enqueue() and Dequeue() nodes. Each linked list can also return the head and tail of the linked list with the Head() and Tail() methods. Finally, linked lists can be searched through using the Find() method.

Example:

```
Node nodeOne = new Node("One");
Node nodeTwo = new Node("Two");
Node nodeThree = new Node("Three");

LinkedListQueue myQueue = new LinkedListQueue;

myQueue.Enqueue(nodeOne);
myQueue.Enqueue(nodeTwo);
myQueue.Enqueue(nodeThree);

myQueue.Dequeue();
myQueue.Find("Three");
```

(note that Dequeue returns the node being dequeued)

When you want to run the unit tests for this project, open the LinkedListQueueProject.vsmdi file inside of visual studio to be brought to the Test List Editor menu.

### License

Copyright 2014 Jacob Mooney

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0
Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.