import { Component, OnInit } from '@angular/core';
import { DictionaryService } from './dictionary.service';
import { Dictionary } from './dictionary.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title: string;
  dictionaries: Dictionary[];
  translate = '';
  communicate: string;
  index = 0;
  disabledButton = false;

  ngOnInit(): void {
    this.onGet();
    this.communicate = 'Start';
  }

  constructor(private dictionaryService: DictionaryService) { }

  onGet() {
    this.dictionaryService.getDictionaries()
      .subscribe(response =>
        this.dictionaries = response
      );
  }

  display() {
    this.communicate = 'Next';
    if (this.index === 7) {
      this.communicate = 'Finish';
    }
    if (this.index === 8) {
      this.disabledButton = true;
      return;
    }
    console.log(this.dictionaries[this.index]);
    this.title = this.dictionaries[this.index].name;
    this.index = this.index + 1;
    this.translate = '';
  }
}
