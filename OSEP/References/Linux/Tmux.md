unbind C-b
set -g prefix C-a
bind C-a send-prefix
setw -g mode-keys vi
set -g history-limit 10000
set -g allow-rename

hunt almost gun bubble guide hobby require all improve hungry run country

tmux new-session \; \
  split-window -v \; \
  split-window -h \; \
  select-pane -t 0 \; \
  split-window -h \; \
  new-window \; \
  split-window -v \; \
  split-window -h \; \
  select-pane -t 0 \; \
  split-window -h \; \
  select-window -t 0 \; \
  select-pane -t 0 \;
  
  rdesktop 192.168.75.11 -u Offsec -p lab -5 -K -r clipboard:CLIPBOARD
  
DotNetToJScript.exe ExampleAssembly.dll --lang=Jscript --ver=v4 -o runner.js