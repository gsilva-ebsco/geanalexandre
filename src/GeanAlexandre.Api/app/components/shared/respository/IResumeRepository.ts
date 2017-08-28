export interface IResumeRepository {
    getResume(userName: string): Promise<string>
}