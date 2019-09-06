Deleting a node from a linked list is fairly straightforward. Given a node n, we find the previous node prev
and set prev. next equal to n. next. If the list is doubly linked, we must also update n. next to set
n. next. prev equal to n. prev. The important things to remember are (1) to check for the null pointer
and (2) to update the head or tail pointer as necessary.

The "Runner"Technique
The "runner" (or second pointer) technique is used in many linked list problems. The runner technique
means that you iterate through the linked list with two pointers simultaneously, with one ahead of the
other. The "fast" node might be ahead by a fixed amount, or it might be hopping multiple nodes for each
one node that the "slow" node iterates through.
For example, suppose you had a linked list a1 - >a2 -> ••• ->an - >b1 ->b2 -> ••• ->bn and you wanted to
rearrange it into a1 ->b1 ->a2 - >b2 -> ••• - >an - >bn. You do not know the length of the linked list (but you
do know that the length is an even number).
You could have one pointer pl (the fast pointer) move every two elements for every one move that p2
makes. When pl hits the end of the linked list, p2 will be at the midpoint. Then, move pl back to the front
and begin "weaving" the elements. On each iteration, p2 selects an element and inserts it after pl.