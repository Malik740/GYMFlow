# GymFlow Documentation

## Overview

GymFlow is a VB.NET Windows Forms desktop application designed to manage gym operations. The system uses VB.NET, Windows Forms, and SQL Server to provide a centralized platform for managing members, attendance, payments, subscriptions, trainers, and products.

The main goal of GymFlow is to replace manual gym management processes with a digital system that improves organization, accuracy, and efficiency.

---

## Main Features

### Login and User Management
**File:** `Login.vb`

Provides user authentication and controls access to the application.

### Dashboard
**File:** `DashBoard.vb`

Displays an overview of gym activities, including important information about members, attendance, and subscriptions.

### Member Management
**File:** `AddMember.vb`

Allows users to add, edit, and manage member information and subscription details.

### Attendance Management
**File:** `Attendance.vb`

Tracks member attendance records and helps monitor gym visits.

### Membership Plans
**File:** `MembershipPlans.vb`

Manages subscription plans, pricing, and membership durations.

### Trainer Management
**File:** `Trainers.vb`

Stores and manages trainer information.

### Product Management
**File:** `Product.vb`

Handles gym product information and management.

---

## How the Application Works

GymFlow uses a Windows Forms interface where each feature is implemented as a separate form. Users interact with the forms to perform operations such as adding members, recording attendance, and managing subscriptions.

The application connects to SQL Server to store and retrieve data. The forms communicate with the database to perform operations such as creating, updating, reading, and deleting records.

High-level workflow:

## Target Users

GymFlow is designed for gym administrators and employees. It helps them manage daily operations, maintain accurate records, and reduce the time required for manual management tasks.