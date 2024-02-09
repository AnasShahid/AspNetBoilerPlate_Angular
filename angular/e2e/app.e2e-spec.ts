import { AspNetBoilerplate_AngularTemplatePage } from './app.po';

describe('AspNetBoilerplate_Angular App', function() {
  let page: AspNetBoilerplate_AngularTemplatePage;

  beforeEach(() => {
    page = new AspNetBoilerplate_AngularTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
