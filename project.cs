
geng @LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ gir branch
bash: gir: command not found

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git branch
* main

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git add .

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git remote -v
origin  git@github.com:gengzhiyao / learn.git(fetch)
origin git@github.com:gengzhiyao / learn.git(push)

geng @LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git push origin main
Everything up-to-date

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git status
On branch main
Your branch is up to date with 'origin/main'.

Changes to be committed:
  (use "git restore --staged <file>..." to unstage)
        modified:   test.txt


geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git diff

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git push
Everything up-to-date

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git diff
diff --git a/test.txt b/test.txt
index 58eea37..4dc48ab 100644
--- a/test.txt
+++ b/test.txt
@@ -1,2 +1,2 @@
-
+111
 11
\ No newline at end of file

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git push
Everything up-to-date

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git diff
diff --git a/test.txt b/test.txt
index 58eea37..4dc48ab 100644
--- a/test.txt
+++ b/test.txt
@@ -1,2 +1,2 @@
-
+111
 11
\ No newline at end of file

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git diff
diff --git a/test.txt b/test.txt
deleted file mode 100644
index 58eea37..0000000
--- a/test.txt
+++ /dev/null
@@ -1,2 +0,0 @@
-
-11
\ No newline at end of file

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git push origin main:main
Everything up-to-date

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git status
On branch main
Your branch is up to date with 'origin/main'.

Changes to be committed:
  (use "git restore --staged <file>..." to unstage)
        modified:   test.txt

Changes not staged for commit:
  (use "git add/rm <file>..." to update what will be committed)
  (use "git restore <file>..." to discard changes in working directory)
        deleted:    test.txt


geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git add .

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git push origin main:main
Everything up-to-date

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git pull
Already up to date.

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git add /
fatal: D:/ Git / Git /: 'D:/Git/Git/' is outside repository at 'E:/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn'

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git add .

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git commit -m "aaa"
[main 0834aa1] aaa
 1 file changed, 1 deletion(-)
 delete mode 100644 test.txt

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git push origin main:main
Connection reset by 20.205.243.166 port 22
fatal: Could not read from remote repository.

Please make sure you have the correct access rights
and the repository exists.

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git push origin main:main
Connection reset by 20.205.243.166 port 22
fatal: Could not read from remote repository.

Please make sure you have the correct access rights
and the repository exists.

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git push origin main:main
Connection reset by 20.205.243.166 port 22
fatal: Could not read from remote repository.

Please make sure you have the correct access rights
and the repository exists.

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git push origin main:main
Enumerating objects: 3, done.
Counting objects: 100 % (3 / 3), done.
Delta compression using up to 20 threads
Compressing objects: 100 % (1 / 1), done.
Writing objects: 100 % (2 / 2), 225 bytes | 225.00 KiB / s, done.
Total 2(delta 0), reused 1 (delta 0), pack-reused 0
To github.com:gengzhiyao / learn.git
   370f81e..0834aa1 main -> main

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git status
On branch main
Your branch is up to date with 'origin/main'.

Untracked files:
  (use "git add <file>..." to include in what will be committed)
        "\346\226\260\345\273\272 Microsoft Word \346\226\207\346\241\243.docx"

nothing added to commit but untracked files present (use "git add" to track)

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git add .

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git status
On branch main
Your branch is up to date with 'origin/main'.

Changes to be committed:
  (use "git restore --staged <file>..." to unstage)
        new file:   "\346\226\260\345\273\272 Microsoft Word \346\226\207\346\241\243.docx"


geng @LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git push origin main:main
Everything up-to-date

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git commit -m "add word"
[main 10fb67a] add word
 1 file changed, 0 insertions(+), 0 deletions(-)
 create mode 100644 "\346\226\260\345\273\272 Microsoft Word \346\226\207\346\241\243.docx"

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn/CatlikeCoding/learn (main)
$ git push origin main:main
Enumerating objects: 4, done.
Counting objects: 100 % (4 / 4), done.
Delta compression using up to 20 threads
Compressing objects: 100 % (2 / 2), done.
Writing objects: 100 % (3 / 3), 298 bytes | 298.00 KiB / s, done.
Total 3(delta 0), reused 0 (delta 0), pack-reused 0
To github.com:gengzhiyao / learn.git
   0834aa1..10fb67a main -> main


geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn
$ git init
Initialized empty Git repository in E:/ App_Data / Unity_Project / UnityLearn /.git /

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn (master)
$ git status
On branch master

No commits yet

Untracked files:
  (use "git add <file>..." to include in what will be committed)
        Hello.c

nothing added to commit but untracked files present (use "git add" to track)

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn (master)
$ git commit -m "first commit"
On branch master

Initial commit

Untracked files:
  (use "git add <file>..." to include in what will be committed)
        Hello.c

nothing added to commit but untracked files present (use "git add" to track)

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn (master)
$ git remote add Test git@github.com:gengzhiyao / learn.git

geng @LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn (master)
$ git pull --rebase Test main
fatal: Updating an unborn branch with changes added to the index.

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn (master)
$ git pull
remote: Enumerating objects: 16, done.
remote: Counting objects: 100 % (16 / 16), done.
remote: Compressing objects: 100 % (12 / 12), done.
remote: Total 16 (delta 2), reused 10 (delta 1), pack-reused 0
Unpacking objects: 100 % (16 / 16), 18.35 KiB | 268.00 KiB / s, done.
From github.com: gengzhiyao / learn
 * [new branch]      main->Test / main
There is no tracking information for the current branch.
Please specify which branch you want to merge with.
See git-pull(1) for details.

    git pull <remote> <branch>

If you wish to set tracking information for this branch you can do so with:

    git branch --set-upstream-to=Test/<branch> master


geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn (master)
$ git pull Test main
From github.com:gengzhiyao / learn
 * branch            main->FETCH_HEAD

geng @LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn (master)
$ git push Test master:main
Everything up-to-date

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn (master)
$ git push Test master:main
Everything up-to-date

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn (master)
$ git commit -m "first commit"
On branch master
Untracked files:
  (use "git add <file>..." to include in what will be committed)
        Hello.c

nothing added to commit but untracked files present (use "git add" to track)

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn (master)
$ git push Test master:main
Everything up-to-date

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn (master)
$ git status
On branch master
Untracked files:
  (use "git add <file>..." to include in what will be committed)
        Hello.c

nothing added to commit but untracked files present (use "git add" to track)

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn (master)
$ git add .

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn (master)
$ git push Test master:main
Everything up-to-date

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn (master)
$ git commit -m "first commit"
[master 723a78e] first commit
 1 file changed, 6 insertions(+)
 create mode 100644 Hello.c

geng@LAPTOP MINGW64 /e/App_Data/Unity_Project/UnityLearn (master)
$ git push Test master:main
Enumerating objects: 4, done.
Counting objects: 100 % (4 / 4), done.
Delta compression using up to 20 threads
Compressing objects: 100 % (3 / 3), done.
Writing objects: 100 % (3 / 3), 314 bytes | 314.00 KiB / s, done.
Total 3(delta 1), reused 0 (delta 0), pack-reused 0
remote: Resolving deltas: 100 % (1 / 1), completed with 1 local object.
To github.com:gengzhiyao / learn.git
   607efd3..723a78e master -> main
