## COMPANY MANAGEMENT SYSTEM
## About
The Company Management System is designed to streamline operations and management tasks within an organization. It provides dedicated dashboards for employees, heads of departments, and administrators, each having specific roles and responsibilities. This system is simple yet highly functional, providing basic needs of employees and the users that use this system.

## User Authentication:

- Users can securely log in using their username and password. Different roles (admin, department head, employee) have distinct access levels and functionalities.

## Admin Dashboard:

- The Admin dashboard displays information for all employees in the company. It enables the admin to add, create, update, or delete user accounts. The system manages employee data including names, roles, and project assignments.

##Head of Department Dashboard:
- The HOD Dashboard shows personal information and details of all employees currently within that department. The HOD can create projects, assign employees to projects, and set project milestones. It also allows the HOD to monitor attendance reports for each employee.

## Employee Dashboard:

- The Employee Dashboard displays personal information for the employee. It allows employees to mark their attendance, view their attendance history, and submit complaints for review by the HOD in the HOD dashboard.

## ERD Diagram of the database:
![Screenshot 2024-07-12 100446](https://github.com/user-attachments/assets/487cd200-d14b-42db-ac3d-60bd45f8b3ff)

(Note there may be 2-3 tables that might be missing, I added them in the end)

## How to Proceed with Setting Up the System
**Step 1: Database Setup**
- Create the Database:
Based on the provided Entity Relationship Diagram (ERD), create the necessary tables and relationships in MySQL.

**Step 2: Update the database credentials in the C# code:**
- Open the C# project in Visual Studio.

- Locate the configuration file or the section in the code where the database connection is defined.

- Update the database name, user, and password with your MySQL credentials

## Support
For questions, suggestions, or issues, please create a pull request or an issue on the GitHub repository. You can also reach out via email at sohaibbazaz@gmail.com  I'm happy to assist with any queries you may have.
