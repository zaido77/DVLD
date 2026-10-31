# 🚗 DVLD — Driving & Vehicle License Department

A C# desktop application for managing driver licensing services, applications, tests, licenses, and system users.

## 📋 Project Overview

DVLD is a project developed as part of the **Programming Advices — Full Project in C#** course. It models the work of a driving license department, from receiving applications and scheduling tests to issuing and managing driving licenses.

## 📁 Project Structure

- `DVLD_Presentation` — Windows Forms interface
- `DVLD_Business` — business logic
- `DVLD_DataAccess` — database access

## 🛠️ Technologies

- C#
- Windows Forms
- SQL Server
- ADO.NET
- Visual Studio

## ✨ Main Services

The project requirements cover these services:

- First-time driving license issuance
- Retaking a failed test
- Driving license renewal
- Replacement of lost or damaged licenses
- Release of detained licenses
- International driving license issuance

## 🪪 License Classes

The system defines seven license classes, with configurable minimum age, validity period, and fees:

1. Small motorcycle
2. Heavy motorcycle
3. Ordinary driving license
4. Commercial driving license
5. Agricultural vehicle license
6. Small and medium bus license
7. Heavy vehicle and truck license

## 🧪 Tests and License Issuance

For first-time license applications, the requirements describe three tests that must be passed in order:

1. Vision test
2. Written test
3. Practical driving test (Street Test)

Test appointments and results are recorded in the system. A license can be issued after the applicant meets the applicable requirements and passes the required tests.

## 🗂️ System Management

The requirements include management features for:

- **People:** search, add, view, edit, and delete people; prevent duplicate national ID numbers
- **Users:** add, view, edit, and delete users; freeze accounts and assign permissions
- **Applications:** search by application number or applicant, view and filter applications, and update application information
- **License classes:** update minimum age, validity period, and fees
- **Detained licenses:** record detention details, fines, and release information

The system also records the user responsible for each operation and the operation date.

## 💻 Screenshots

<img width="1592" height="898" alt="Screenshot 2026-10-31 144309" src="https://github.com/user-attachments/assets/3101f387-bd60-43d8-ac8f-758e71fda988" />
<img width="1917" height="1012" alt="Screenshot 2026-10-31 144331" src="https://github.com/user-attachments/assets/12953a5f-bcb0-46fd-a2eb-fed277214f7a" />
<img width="1917" height="1009" alt="Screenshot 2026-10-31 144353" src="https://github.com/user-attachments/assets/85de59e7-0f4c-4cdb-b7ba-73f4df503c26" />
<img width="1917" height="1023" alt="Screenshot 2026-10-31 151229" src="https://github.com/user-attachments/assets/bd884484-cf7f-4ea8-b4e5-88d52e6319a5" />
<img width="1917" height="1020" alt="Screenshot 2026-10-31 151627" src="https://github.com/user-attachments/assets/62475f16-e684-4f51-bccb-d8440bc7570d" />
<img width="1535" height="815" alt="Screenshot 2026-10-31 151933" src="https://github.com/user-attachments/assets/6f947bbf-2add-437c-a15f-ed853e96f94d" />
<img width="1535" height="815" alt="Screenshot 2026-10-31 152340" src="https://github.com/user-attachments/assets/3d28979b-4d31-465b-abcc-30ec16e00d90" />
<img width="1535" height="814" alt="Screenshot 2026-10-31 152312" src="https://github.com/user-attachments/assets/8d7aa862-19bb-4499-b35c-fe8c7a82d3f9" />
<img width="1535" height="814" alt="Screenshot 2026-10-31 152430" src="https://github.com/user-attachments/assets/59763ed5-9f58-4dbc-8015-559b35bf9833" />
<img width="1529" height="814" alt="Screenshot 2026-10-31 152502" src="https://github.com/user-attachments/assets/8f149683-bfbb-4c00-8f48-42f2775b101d" />
<img width="1535" height="814" alt="Screenshot 2026-10-31 152523" src="https://github.com/user-attachments/assets/d16f1b93-86de-4c55-8d1d-731e8a5f8674" />
<img width="1535" height="812" alt="Screenshot 2026-10-31 152557" src="https://github.com/user-attachments/assets/0467bb9b-db84-4841-a44d-c61bbd816d23" />
<img width="1534" height="815" alt="Screenshot 2026-10-31 152708" src="https://github.com/user-attachments/assets/51eab6e8-2c28-4aba-9065-f62dbfd3425c" />
<img width="1535" height="817" alt="Screenshot 2026-10-31 152847" src="https://github.com/user-attachments/assets/832ce306-4bab-4969-82c8-09cb7c4071fc" />
<img width="1535" height="816" alt="Screenshot 2026-10-31 152814" src="https://github.com/user-attachments/assets/e4359bad-ac38-4859-a083-b038deddab08" />
<img width="1535" height="815" alt="Screenshot 2026-10-31 152739" src="https://github.com/user-attachments/assets/458c8ae3-30db-48c1-b7a9-2c3d24abd941" />
<img width="1535" height="816" alt="Screenshot 2026-10-31 153558" src="https://github.com/user-attachments/assets/5d95784d-78ce-4928-898f-bdf784dc26f2" />
<img width="1535" height="813" alt="Screenshot 2026-10-31 153455" src="https://github.com/user-attachments/assets/3cdd8dc2-9529-4a76-8df9-2246dbdbbf27" />
<img width="1535" height="812" alt="Screenshot 2026-10-31 153339" src="https://github.com/user-attachments/assets/e485b067-0cbb-4436-8a19-dcf945c8429f" />
<img width="1535" height="814" alt="Screenshot 2026-10-31 153301" src="https://github.com/user-attachments/assets/ff2c8428-ca39-4d51-915c-cf0abfc7c21b" />
<img width="1535" height="814" alt="Screenshot 2026-10-31 153159" src="https://github.com/user-attachments/assets/626429e3-bfce-4c0b-8236-f1a5d5928da7" />
<img width="1533" height="816" alt="Screenshot 2026-10-31 153124" src="https://github.com/user-attachments/assets/fcfcb757-c999-499a-9078-fa738017a4bc" />
<img width="1535" height="814" alt="Screenshot 2026-10-31 153056" src="https://github.com/user-attachments/assets/06a8c4ae-2fe7-4e4c-aa1e-64c29eab1bf2" />
<img width="1535" height="817" alt="Screenshot 2026-10-31 153032" src="https://github.com/user-attachments/assets/f2ca1ca4-56f1-47c8-8d89-870aa01c5a96" />
<img width="1535" height="813" alt="Screenshot 2026-10-31 152905" src="https://github.com/user-attachments/assets/4214c4de-0cc4-40e7-b1e1-a6cf3bd80db9" />
