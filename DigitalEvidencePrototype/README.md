# Digital Evidence Prototype (F#)

> **Educational & Research Prototype**
>
> This project is an early-stage desktop application prototype that demonstrates how digital evidence can be imported, hashed using **SHA-256**, and associated with a simple certificate.
>
> **This project is NOT intended for real investigations or legal proceedings.**
>
> It does **not** claim to be:
>
> - Court-approved
> - Police-ready
> - A legally valid certificate generator
> - Suitable for direct evidence submission
>
> The long-term objective is to learn software architecture, cryptography fundamentals, file processing, and digital evidence management while gradually evolving toward a more complete digital evidence platform.

---

# Project Goals

This prototype demonstrates how to:

- Import a digital evidence file
- Compute a SHA-256 cryptographic hash
- Associate evidence with a case
- Generate a basic certificate
- Organize the project using layered architecture

Rather than focusing only on cryptography, the project also emphasizes good software engineering practices such as modular design and separation of concerns.

---

# Why SHA-256?

A cryptographic hash acts like a unique digital fingerprint.

If **even one byte** of a file changes,

- the hash changes completely
- the modification becomes detectable

```
Original File
      │
      ▼
Generate SHA-256
      │
      ▼
Unique Fingerprint
```

This allows future verification that the evidence has not been modified.

---

# Overall Workflow

```
Evidence File
      │
      ▼
Read File
      │
      ▼
Generate SHA-256
      │
      ▼
Create Evidence Model
      │
      ▼
Generate Certificate
      │
      ▼
Display Result
```

---

# Project Architecture

```
                Program.fs
                     │
        ┌────────────┴────────────┐
        ▼                         ▼
    Hash.fs                Certificate.fs
        │                         │
        └────────────┬────────────┘
                     ▼
                 Models.fs
```

Each module has a single responsibility.

| Module | Responsibility |
|---------|---------------|
| Program.fs | User interaction and application flow |
| Hash.fs | SHA-256 hash generation |
| Models.fs | Domain models |
| Certificate.fs | Certificate generation |

This layered design makes future expansion significantly easier.

---

# Current Features (v0.1)

Current implementation includes:

- File I/O
- SHA-256 hashing
- Case information
- Evidence information
- Basic certificate generation
- Layered architecture
- End-to-end console workflow

---

# Console Workflow

```
=========================================
Digital Evidence Prototype v0.1
=========================================

Case Number :
Case Name :
Investigator :
Evidence File Path :

Generating SHA-256...

Certificate Generated
```

---

# Sample Processing Flow

```
User

 │

 ▼

Enter Case Details

 │

 ▼

Select Evidence File

 │

 ▼

Read File

 │

 ▼

Compute SHA-256

 │

 ▼

Create Domain Objects

 │

 ▼

Generate Certificate

 │

 ▼

Display Output
```

---

# Understanding the Software from a Computer Science Perspective

This prototype demonstrates several important Computer Science concepts.

## File I/O

The application reads evidence files safely from storage.

```
Storage

 │

 ▼

Application

 │

 ▼

Memory
```

---

## Cryptography

SHA-256 converts arbitrary file data into a fixed-size cryptographic digest.

```
Input File

 │

 ▼

SHA-256 Algorithm

 │

 ▼

Hash Value
```

Hashing is a **one-way operation**, meaning the original file cannot be reconstructed from its hash.

---

## Domain Modeling

Real-world concepts are represented using structured models.

```
Case

 ├── Case Number

 ├── Case Name

 └── Investigator


Evidence

 ├── File Name

 ├── File Path

 ├── SHA-256

 └── Import Time
```

This approach improves maintainability and readability.

---

## Layered Architecture

Instead of placing all logic inside one source file, responsibilities are separated.

```
Presentation

      │

Business Logic

      │

Domain Models

      │

Utilities
```

Such modular architecture is widely used in enterprise software development.

---

# Understanding the Same Project from a Civil / Mechanical Engineering Perspective

Although this project belongs to Computer Science, many of its ideas resemble concepts familiar to Civil and Mechanical Engineering.

---

## Structural Drawing Analogy

A structural drawing documents exactly how a structure was designed.

Similarly,

a SHA-256 hash documents the exact digital state of a file.

```
Building

      │

Blueprint

      │

Verification
```

```
Digital File

      │

SHA-256

      │

Verification
```

Both act as reference records.

---

## Material Identification

Engineers verify materials before construction.

Likewise,

digital investigators verify evidence before analysis.

```
Material

      │

Inspection

      │

Acceptance
```

```
Digital File

      │

Hash Verification

      │

Acceptance
```

---

## Quality Control Analogy

Quality control ensures manufactured parts remain unchanged.

Digital hashing serves a similar purpose.

```
Component

      │

Inspection

      │

Quality Record
```

```
Evidence

      │

SHA-256

      │

Integrity Record
```

Both establish confidence in the object's condition.

---

## Documentation Analogy

Engineering projects require documentation throughout their lifecycle.

Similarly, digital investigations rely on organized records describing evidence and its history.

```
Project

      │

Documentation

      │

Future Reference
```

```
Digital Evidence

      │

Certificate

      │

Future Verification
```

---

# Running the Project

## Clone

```bash
git clone <repository-url>
cd DigitalEvidencePrototype
```

---

## Build

```bash
dotnet build
```

---

## Run

```bash
dotnet run
```

---

## Example Input

```
Case Number

Case Name

Investigator

Evidence File Path
```

After processing, the application computes the SHA-256 hash and generates a prototype certificate.

---

# Learning Outcomes

This small project introduces several useful topics.

- Functional programming with F#
- File processing
- SHA-256 hashing
- Modular software design
- Domain-driven thinking
- Certificate generation
- Console application development

---

# Current Development Roadmap

```
v0.1

✓ SHA-256

        │

        ▼

v0.2

SQLite Database

        │

        ▼

v0.3

PDF Certificate Generation

        │

        ▼

v0.4

Hash Verification

        │

        ▼

v0.5

WhatsApp Chat Import

        │

        ▼

v0.6

Chain of Custody

        │

        ▼

v0.7

Avalonia Desktop GUI

        │

        ▼

v1.0

Digital Evidence Platform
```

---

# Long-Term Architecture Vision

```
Phase 1

Console Prototype

        │

        ▼

Phase 2

SQLite Storage

        │

        ▼

Phase 3

PDF Generation

        │

        ▼

Phase 4

WhatsApp Import

        │

        ▼

Phase 5

Chain of Custody

        │

        ▼

Phase 6

Avalonia GUI

        │

        ▼

Phase 7

Native C++ Evidence Engine

        │

        ▼

DigitalEvidence v1.0
```

---

# Possible Future Features

- SQLite-based evidence storage
- Multiple evidence items per case
- PDF certificate generation
- Hash verification module
- Directory hashing
- Batch evidence import
- WhatsApp export parser
- Email evidence import
- Image metadata extraction
- Video metadata extraction
- Chain of custody tracking
- Audit logging
- Search functionality
- Avalonia desktop interface
- Native C++ evidence processing engine
- Plugin architecture
- Multi-language support

---

# Educational Purpose

This repository is intended for:

- Students learning F#
- Software architecture enthusiasts
- Cybersecurity learners
- Digital forensics beginners
- Engineering students interested in interdisciplinary software projects

---

# Disclaimer

This repository is an educational prototype created for learning and research.

It is **not** intended to replace professional digital forensics software, legal procedures, or certified evidence management systems. Any future legal or investigative use would require significant additional development, validation, testing, and compliance with applicable laws and standards.

---

# License

Released under the MIT License.
