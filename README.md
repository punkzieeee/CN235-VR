# CN235-VR

Aplikasi ini dibuat untuk keperluan tugas akhir (skripsi). Untuk menjalankan aplikasi ini dibutuhkan gear VR dan controller bluetooth.

Cara penggunaan:
- Trigger pada gear VR untuk memilih/touch screen. Jika tidak ada trigger di gear VR bisa menggunakan controller bluetooth dengan pengaturan mouse.
- Kontrol gerakan di hangar dan interior dengan analog di controller bluetooth. Pastikan controller disetel ke pengaturan game.

Spek minimum:
- Android versi 7.0 (Nougat)
- Support VR (Cardboard)

Changelog
---------
v3.1 (https://youtu.be/ruYDZukePqw)
- Tombol untuk jenis pesawat dibedakan berdasarkan warna.
- Teks informasi pesawat diperjelas.
- Penambahan normal badan pesawat untuk point of view interior.
- Penambahan tembok transparant untuk interior.

v4.0
- Penambahan lightning pada kabin versi penumpang.
- Pembaruan tekstur kursi, lantai, dan dinding kabin pesawat versi penumpang.
- Perluasan daerah tembok transparant untuk interior.

v4.1
- Penambahan jumlah lightning pada kabin versi penumpang.
- Perubahan kode teleportasi untuk penentuan titik muncul (spawn) dari koordinat Vector3 baru menjadi koordinat Plane.
- Perubahan kompres build aplikasi dari LZ4 menjadi LZ4HC.

v5.0 (https://youtu.be/uy4K-TkMXOI)
- Penambahan jumlah lightning pada samping kabin versi penumpang.
- Penambahan backsound di menu utama dan scene hangar.
- Perombakan tembok transparant pada pesawat versi penumpang dan gunship.
- Perubahan font pada teks penjelasan pesawat.
- Penambahan marker oranye di lantai hangar untuk arah masuk ke interior. Gunakan marker untuk patokan posisi awal teleportasi dan arahkan pointer ke tengah pintu pesawat.

Bug
---
- Teleportasi seharusnya masuk ke interior, namun justru mendarat di atas/luar pesawat. 
Solusi: Sudut kemiringan pointer dan jarak ke pintu pesawat diperhatikan sebelum memilih pintu pesawat agar tidak mendarat di tempat lain.
- Ada kemungkinan terpental walaupun player terhalang tembok transparant pada interior.

QnA
---
Jika ada yang ditanyakan bisa melalui email (fajaragung4to11@gmail.com) atau tinggalkan pertanyaan di komentar video demo run (https://youtu.be/uy4K-TkMXOI)
