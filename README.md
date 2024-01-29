Aplikasi Perkuliahan
Deskripsi

Aplikasi Perkuliahan adalah sebuah sistem manajemen informasi yang dirancang untuk membantu pengelolaan data mahasiswa, perkuliahan, dan informasi terkait dalam suatu institusi pendidikan. Aplikasi ini menggunakan SQL Server sebagai database untuk menyimpan dan mengelola data-data penting.
Fitur Utama

    Manajemen Mahasiswa:
        Pendaftaran mahasiswa baru.
        Pembaruan informasi mahasiswa.
        Pencarian mahasiswa berdasarkan nama atau nim.

    Manajemen Perkuliahan:
        Penjadwalan perkuliahan.
        Pembaruan atau pembatalan perkuliahan.
        Pencarian perkuliahan berdasarkan mata kuliah atau dosen.

    Integrasi dengan SQL Server:
        Penyimpanan data mahasiswa, perkuliahan, dan informasi terkait menggunakan SQL Server.
        Koneksi aman dan efisien ke database untuk operasi CRUD.

Penggunaan Aplikasi
Prasyarat

    ASP.NET MVC Runtime
    SQL Server dan database yang telah disiapkan.

Instalasi

    Clone repositori ini ke dalam sistem lokal Anda.

    bash

git clone https://github.com/namauser/repo-perkuliahan.git

Buka proyek menggunakan Visual Studio atau editor kode favorit Anda.

Konfigurasi Koneksi Database:

    Buka file appsettings.json.
    Sesuaikan string koneksi database pada bagian "ConnectionStrings".

Jalankan Migrasi Database:

    Buka Package Manager Console.
    Jalankan perintah:

    mathematica

        Update-Database

    Jalankan Aplikasi:
        Tekan F5 atau pilih menu "Start Debugging" pada Visual Studio.

Kontribusi

Silakan berkontribusi dengan membuat pull request atau melaporkan issue jika Anda menemukan bug atau memiliki ide perbaikan.
