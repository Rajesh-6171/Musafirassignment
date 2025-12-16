# 📘 Musafir Assignment (.NET Core Console Application)

This repository contains the implementation of the **Musafir assignment** using a **.NET Core Console Application**.
The project demonstrates logical problem-solving, data structure usage, and basic system/database design concepts.

---

## 📌 Assignment Overview

The assignment consists of **four questions**, all of which have been implemented and verified with console output.

---

## 1️⃣ Unique Fruits

**Problem:**
Given two lists of fruits, return only those fruits that appear **exactly once** across both lists combined.
Any fruit that appears more than once (either in the same list or across both lists) is excluded.

**Input Example:**

* List 1: mango, banana, orange, banana
* List 2: apple, mango, watermelon

**Output:**

```
orange, apple, watermelon
```

---

## 2️⃣ Database Design (Conceptual)

**Problem:**
Design a database model for a company that manufactures mirrors (Small, Medium, Large) and needs to track:

* Customer orders
* Production
* Packaging
* Delivery status

**Designed Tables:**

```
Customer(CustomerId, Name, Phone, Address)
Product(ProductId, ProductType, Price)
Order(OrderId, CustomerId, OrderDate, Status)
OrderItem(OrderItemId, OrderId, ProductId, Quantity)
OrderTracking(OrderId, ProductionStatus, PackagingStatus, DeliveryStatus)
```

📄 The complete database design is stored in:

```
DatabaseDesign.txt
```

---

## 3️⃣ Nth Node From End of Singly Linked List

**Problem:**
Given a singly linked list, find the **N-th node from the end**.

**Example:**

```
Linked List: 1 → 2 → 3 → 4
N = 2
```

**Output:**

```
3
```

**Approach Used:**

* Two-pointer technique
* Time Complexity: O(n)
* Space Complexity: O(1)

---

## 4️⃣ Compare Two Integers Without if-else

**Problem:**
Given two integers A and B, return which variable holds the greater value **without using if-else or ternary operators**.

**Example:**

```
A = 10
B = 20
```

**Output:**

```
B is greater
```

---

## ▶️ How to Run the Project

### Prerequisites

* .NET SDK 8.0 (or compatible version)

### Steps

```bash
dotnet restore
dotnet run
```

---

## 🖥️ Console Output (Verified)

```
===== Musafir Assignment =====

Question-1. Unique Fruits:
List 1: mango, banana, orange, banana
List 2: apple, mango, watermelon
Result:
orange, apple, watermelon

Question-2. Database Design:
Customer(CustomerId, Name, Phone, Address)
Product(ProductId, ProductType, Price)
Order(OrderId, CustomerId, OrderDate, Status)
OrderItem(OrderItemId, OrderId, ProductId, Quantity)
OrderTracking(OrderId, ProductionStatus, PackagingStatus, DeliveryStatus)

Question-3. Nth Node From End:
Linked List: 1 -> 2 -> 3 -> 4
N = 2
Result: 3

Question-4. Compare A and B:
A = 10, B = 20
Result: B is greater
```

---

## 📂 Project Structure

```
Musafirassignment/
├── CompareValues.cs
├── FruitLogic.cs
├── LinkedListLogic.cs
├── Program.cs
├── DatabaseDesign.txt
├── Musafirassignment.csproj
├── Musafirassignment.sln
└── README.md
```

---

## 🛠️ Technologies Used

* C#
* .NET Core 8.0
* Console Application
* GitHub

---

## ✅ Status

✔ Assignment completed
✔ Output verified using Visual Studio
✔ Ready for review

---

## 👤 Author

**Rajesh Sawant**
GitHub: [https://github.com/Rajesh-6171](https://github.com/Rajesh-6171)



If you paste this README, your repository will look **professional, complete, and interview-ready** ✅
If you want a **short HR-friendly version** or **add screenshots section**, I can do that too 👍
