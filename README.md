# Mini-Attendance
**Attendance Management System - Database Description**

The Attendance Management System is a comprehensive application designed to streamline and enhance the process of tracking attendance, managing students, classes, events, and administrative functions within an educational institution. The system utilizes a relational database named `db_attendance` to efficiently organize and store key information. Here's an overview :

1. **Mahasiswa (Students) Management:**
   - The system allows for the efficient storage and retrieval of student information, including names, student IDs (NIM), emails, and passwords.
   - Enables administrators and lecturers to manage student records seamlessly.

2. **Event Management:**
   - Facilitates the planning and organization of events, including details such as event names, locations, dates, participants, and associated images.
   - Provides a centralized platform to oversee and coordinate various events within the institution.

3. **Administrator Access:**
   - Grants authorized administrators secure access to the system with unique usernames and passwords.
   - Ensures administrative control over user management and system configuration.

4. **Dosen (Lecturers) Management:**
   - Manages lecturer information, including names, lecturer IDs (NIP), emails, and passwords.
   - Associates lecturers with specific classes, establishing a link between faculty and courses.

5. **Kelas (Classes) Management:**
   - Organizes classes with details such as class names, start dates, end dates, and associated lecturers.
   - Establishes a structured framework for managing the academic schedule.

6. **Kehadiran (Attendance) Tracking:**
   - Tracks student attendance in various classes, recording dates and attendance statuses.
   - Provides insights into student participation and engagement within the academic environment.

7. **Event Attendance Tracking:**
   - Monitors attendance at events, capturing participation data for both students and lecturers.
   - Enhances event planning and evaluation by analyzing attendance metrics.

## Sample Data and Initialization
- The system comes pre-populated with sample data for Dosen, Mahasiswa, and Administrator tables.
- Demonstrates the application's functionality with two lecturers, two students, and an administrator account.
   - Admin | Username : admin | Password : 12345678
   - Dosen | Username : NIP123 | Password : 123456
   - Mahasiswa | Username : NIM123 | Password : 123456

## Built With

* [![C#][CSharp-img]][CSharp-url]
* [![Visual Studio 2022][VS2022-img]][VS2022-url]
* [![Microsoft SQL Server][SqlServer-img]][SqlServer-url]
* [![CsvHelper][CsvHelper-img]][CsvHelper-url]
* [![iText][iText-img]][iText-url]

[CSharp-img]: https://img.shields.io/badge/language-C%23-blue
[CSharp-url]: https://docs.microsoft.com/en-us/dotnet/csharp/

[VS2022-img]: https://img.shields.io/badge/IDE-Visual%20Studio%202022-purple
[VS2022-url]: https://visualstudio.microsoft.com/vs/

[SqlServer-img]: https://img.shields.io/badge/database-Microsoft%20SQL%20Server-orange
[SqlServer-url]: https://www.microsoft.com/en-us/sql-server

[CsvHelper-img]: https://img.shields.io/badge/library-CsvHelper-green
[CsvHelper-url]: https://joshclose.github.io/CsvHelper/

[iText-img]: https://img.shields.io/badge/library-iText-red
[iText-url]: https://itextpdf.com/

## **User Interface**
- Login
![image](https://github.com/seoeka/mini-attendance/assets/87307944/2856884d-0e10-4d80-8365-060cffdbc0cd)

- Beranda
![image](https://github.com/seoeka/mini-attendance/assets/87307944/1c8fac5e-16a7-4175-8a62-bb3c381acd44)

- Dosen
![image](https://github.com/seoeka/mini-attendance/assets/87307944/eb3f60c3-9b5c-442d-92e5-ee7e845bc69f)

- Mahasiswa
![image](https://github.com/seoeka/mini-attendance/assets/87307944/62619f3c-f25c-43d0-b7ac-14e920acb42d)

- Kelas
![image](https://github.com/seoeka/mini-attendance/assets/87307944/3ba20764-d3aa-4c7b-bd20-10addb21f604)

- Kehadiran
![image](https://github.com/seoeka/mini-attendance/assets/87307944/6ff78314-d16e-4610-bd00-69ffaf120777)

- Acara
![image](https://github.com/seoeka/mini-attendance/assets/87307944/edbcffe1-8e2f-4fd1-bf7d-3277602946b7)

- Laporan
![image](https://github.com/seoeka/mini-attendance/assets/87307944/0607d5bb-d164-4f67-9062-87d0b2651b65)

Dosen overview
![image](https://github.com/seoeka/mini-attendance/assets/87307944/38d3ac5c-ca75-437a-9b8f-395923b70076)

Mahasiswa overview
![image](https://github.com/seoeka/mini-attendance/assets/87307944/14ea1e4d-59c0-403f-b2da-9cdae4f12756)
