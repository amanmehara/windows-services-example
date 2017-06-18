# windows-services-example

### An Example Windows Services Application
*(Long running executable applications that run in their own Windows sessions)*

### Built On: Visual Studio 2017

### Instructions:
* Clone repository
* Build the Solution
* Open Developer Command Prompt for VS as Admin
* **Execute:** cd "${Build Output Directory}"
* **Execute:** InstallUtil "Windows Services.exe"
* **Execute:** sc start "Timer Service"
* Wait for 5-10 minutes
* **Execute:** sc stop "Timer Service"
* **Execute:** sc delete "Timer Service"
* Close Developer Command Prompt
* Open Build Output Directory in Explorer
* Open **logfile** to view service logs
