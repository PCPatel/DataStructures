class Node {
  constructor(value) {
    this.value = value
    this.next = null
  }
}

class LinkedList {
  constructor() {
    this.head = null
    this.tail = null
  }

  AddToBack(value) {
    let ref = new Node(value)
    if (this.head === null) {
      this.head = ref
      this.tail = ref
    } else {
      this.tail.next = ref
      this.tail = ref
    }
  }

  AddToFront(value) {
    let ref = new Node(value)
    if (this.head === null) {
      this.head = ref
      this.tail = ref
    } else {
      ref.next = this.head;
      this.head = ref
    }
  }

  AddAfter(searchValue, newValue) {
    for (let current = this.head; current != null; current = current.next) {
      if (current.value === searchValue) {
        if (current === this.tail) {
          this.Add(newValue)
          return true
        }
        let ref = new Node(newValue)
        ref.next = current.next
        current.next = ref
        return true
      }
    }
  }

  Print() {
    for (let current = this.head; current != null; current = current.next) {
      console.log(current.value)
    }
  }
}
console.clear()

let l = new LinkedList()
l.AddToBack(1)
l.AddToBack(2)
l.AddToBack(3)
l.AddToFront(4)
//l.Print()
l.AddAfter(4, 4)
l.Print()
