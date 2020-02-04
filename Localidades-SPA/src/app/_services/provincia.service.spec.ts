/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { ProvinciaService } from './provincia.service';

describe('Service: Provincia', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ProvinciaService]
    });
  });

  it('should ...', inject([ProvinciaService], (service: ProvinciaService) => {
    expect(service).toBeTruthy();
  }));
});
